using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HtmlGenerator.Tests
{
    public partial class HtmlElementTests
    {
        [Theory]
        [MemberData(nameof(Objects_TestData))]
        public void ReplaceAll(HtmlObject[] content)
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h1"), new HtmlAttribute("a"), new HtmlAttribute("b"), new HtmlComment("comment"));
            element.ReplaceAll(content);
            Assert.Equal(content.Where(obj => obj is HtmlElement).Cast<HtmlElement>().ToArray(), element.Elements().ToArray());
            Assert.Equal(content.Where(obj => obj is HtmlAttribute).Cast<HtmlAttribute>().ToArray(), element.Attributes().ToArray());
            Assert.Equal(element.Elements().Count() + element.Attributes().Count(), element.ElementsAndAttributes().Count());
            Assert.Equal(element.Nodes().Count() + element.Attributes().Count(), element.NodesAndAttributes().Count());
        }

        [Fact]
        public void ReplaceAll_ParamsHtmlObject_AttributeToVoidElement()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            element.Add(new HtmlAttribute("a"));

            HtmlAttribute[] attributes = new HtmlAttribute[] { new HtmlAttribute("b"), new HtmlAttribute("c") };
            element.ReplaceAll(attributes);
            Assert.Equal(attributes, element.Attributes());
        }

        [Fact]
        public void ReplaceAll_IEnumerableHtmlObject_AttributeToVoidElement()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            element.Add(new HtmlAttribute("a"));

            HtmlAttribute[] attributes = new HtmlAttribute[] { new HtmlAttribute("b"), new HtmlAttribute("c") };
            element.ReplaceAll((IEnumerable<HtmlObject>)attributes);
            Assert.Equal(attributes, element.Attributes());
        }

        [Fact]
        public void ReplaceAll_NullContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<ArgumentNullException>("content", () => element.ReplaceAll(null));
            Assert.Throws<ArgumentNullException>("content", () => element.ReplaceAll((IEnumerable<HtmlObject>)null));
        }

        [Fact]
        public void ReplaceAll_SameElementInContent_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<InvalidOperationException>(() => element.ReplaceAll(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.ReplaceAll((IEnumerable<HtmlObject>)new HtmlObject[] { element }));
        }

        [Fact]
        public void ReplaceAll_DuplicateElementInContents_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlElement newElement = new HtmlElement("p");
            element.Add(newElement);

            Assert.Throws<InvalidOperationException>(() => element.ReplaceAll(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.ReplaceAll((IEnumerable<HtmlObject>)new HtmlObject[] { newElement }));
        }

        [Fact]
        public void ReplaceAll_DuplicateAttributeInContents_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlAttribute newAttribute = new HtmlAttribute("attribute1");
            element.Add(newAttribute);

            Assert.Throws<InvalidOperationException>(() => element.ReplaceAll(new HtmlObject[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.ReplaceAll((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute }));
        }

        [Fact]
        public void ReplaceAll_ElementToVoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            HtmlElement newElement = new HtmlElement("p");

            Assert.Throws<InvalidOperationException>(() => element.ReplaceAll(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.ReplaceAll((IEnumerable<HtmlObject>)new HtmlObject[] { newElement }));
        }

        public static IEnumerable<object[]> Elements_TestData()
        {
            yield return new object[] { new HtmlElement[0] };
            yield return new object[] { new HtmlElement[] { new HtmlElement("h1") } };
            yield return new object[] { new HtmlElement[] { new HtmlElement("h1"), new HtmlElement("h2") } };
            yield return new object[] { new HtmlElement[] { new HtmlElement("h1"), new HtmlElement("h2"), new HtmlElement("h1") } };
        }

        [Theory]
        [MemberData(nameof(Elements_TestData))]
        public void ReplaceElements_ParamsHtmlElement(HtmlElement[] elements)
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h3"), new HtmlAttribute("a"), new HtmlAttribute("b"));
            element.ReplaceElements(elements);
            Assert.Equal(elements, element.Elements().ToArray());
            Assert.Equal(2, element.Attributes().Count());
            Assert.Equal(elements.Length + 2, element.ElementsAndAttributes().Count());
        }

        [Theory]
        [MemberData(nameof(Elements_TestData))]
        public void ReplaceElements_IEnumerableHtmlElement(HtmlElement[] elements)
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h3"), new HtmlAttribute("a"), new HtmlAttribute("b"));
            element.ReplaceElements(elements);
            Assert.Equal(elements, element.Elements().ToArray());
            Assert.Equal(2, element.Attributes().Count());
            Assert.Equal(elements.Length + 2, element.ElementsAndAttributes().Count());
        }

        [Fact]
        public void ReplaceElements_NullElements_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<ArgumentNullException>("elements", () => element.ReplaceElements(null));
            Assert.Throws<ArgumentNullException>("elements", () => element.ReplaceElements((IEnumerable<HtmlElement>)null));
        }

        [Fact]
        public void ReplaceElements_NullElementInElements_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<ArgumentNullException>("content", () => element.ReplaceElements(new HtmlElement[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.ReplaceElements((IEnumerable<HtmlElement>)new HtmlElement[] { null }));
        }

        [Fact]
        public void ReplaceElements_SameElementInElements_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<InvalidOperationException>(() => element.ReplaceElements(new HtmlElement[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.ReplaceElements((IEnumerable<HtmlElement>)new HtmlElement[] { element }));
        }

        [Fact]
        public void ReplaceElements_DuplicateElementInElements_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlElement newElement = new HtmlElement("p");
            element.Add(newElement);

            Assert.Throws<InvalidOperationException>(() => element.ReplaceElements(new HtmlElement[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.ReplaceElements((IEnumerable<HtmlElement>)new HtmlElement[] { newElement }));
        }

        [Fact]
        public void ReplaceElements_ElementToVoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            HtmlElement newElement = new HtmlElement("p");

            Assert.Throws<InvalidOperationException>(() => element.ReplaceElements(new HtmlElement[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.ReplaceElements((IEnumerable<HtmlElement>)new HtmlElement[] { newElement }));
        }

        [Theory]
        [MemberData(nameof(Attributes_TestData))]
        public void ReplaceAttributes_ParamsHtmlAttribute(HtmlAttribute[] attributes)
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h1"), new HtmlAttribute("a"), new HtmlAttribute("b"));
            element.ReplaceAttributes(attributes);
            Assert.Equal(1, element.Elements().Count());
            Assert.Equal(attributes, element.Attributes().ToArray());
            Assert.Equal(1 + attributes.Length, element.ElementsAndAttributes().Count());
        }

        [Fact]
        public void ReplaceAttributes_ParamsHtmlAttribute_VoidElement()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            element.Add(new HtmlAttribute("a"));

            HtmlAttribute[] attributes = new HtmlAttribute[] { new HtmlAttribute("b"), new HtmlAttribute("c") };
            element.ReplaceAttributes(attributes);
            Assert.Equal(attributes, element.Attributes());
        }

        [Theory]
        [MemberData(nameof(Attributes_TestData))]
        public void ReplaceAttributes_IEnumerableHtmlAttribute(HtmlAttribute[] attributes)
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h1"), new HtmlAttribute("a"), new HtmlAttribute("b"));
            element.ReplaceAttributes((IEnumerable<HtmlAttribute>)attributes);
            Assert.Equal(1, element.Elements().Count());
            Assert.Equal(attributes, element.Attributes().ToArray());
            Assert.Equal(1 + attributes.Length, element.ElementsAndAttributes().Count());
        }

        [Fact]
        public void ReplaceAttributes_IEnumerableHtmlAttribute_VoidElement()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            element.Add(new HtmlAttribute("a"));

            HtmlAttribute[] attributes = new HtmlAttribute[] { new HtmlAttribute("b"), new HtmlAttribute("c") };
            element.ReplaceAttributes((IEnumerable<HtmlAttribute>)attributes);
            Assert.Equal(attributes, element.Attributes());
        }

        [Fact]
        public void ReplaceAttributes_NullElements_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<ArgumentNullException>("attributes", () => element.ReplaceAttributes(null));
            Assert.Throws<ArgumentNullException>("attributes", () => element.ReplaceAttributes((IEnumerable<HtmlAttribute>)null));
        }

        [Fact]
        public void ReplaceAttributes_NullAttributeInAttributes_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<ArgumentNullException>("content", () => element.ReplaceAttributes(new HtmlAttribute[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.ReplaceAttributes((IEnumerable<HtmlAttribute>)new HtmlAttribute[] { null }));
        }

        [Fact]
        public void ReplaceAttributes_DuplicateAttributeInAttribues_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlAttribute newAttribute = new HtmlAttribute("attribute1");
            element.Add(newAttribute);

            Assert.Throws<InvalidOperationException>(() => element.ReplaceAttributes(new HtmlAttribute[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.ReplaceAttributes((IEnumerable<HtmlAttribute>)new HtmlAttribute[] { newAttribute }));
        }

        [Theory]
        [InlineData("InnerText")]
        [InlineData(" \t \r \n")]
        [InlineData("")]
        [InlineData(null)]
        public void SetInnerText(string innerText)
        {
            HtmlElement element = new HtmlElement("html");
            element.SetInnerText(innerText);
            Assert.Equal(innerText, element.InnerText);
        }

        [Fact]
        public void SetInnerText_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html", isVoid: true);
            Assert.Throws<InvalidOperationException>(() => element.SetInnerText("InnerText"));
        }
    }
}
