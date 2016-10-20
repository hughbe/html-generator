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
            HtmlElement parent = new HtmlElement("parent", new HtmlElement("element"), new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2"), new HtmlComment("comment"));

            parent.ReplaceAll(content);
            Assert.Equal(content.OfType<HtmlElement>().ToArray(), parent.Elements().ToArray());
            Assert.Equal(content.OfType<HtmlAttribute>().ToArray(), parent.Attributes().ToArray());
            Assert.Equal(parent.Elements().Count() + parent.Attributes().Count(), parent.ElementsAndAttributes().Count());
            Assert.Equal(parent.Nodes().Count() + parent.Attributes().Count(), parent.NodesAndAttributes().Count());
        }

        [Fact]
        public void ReplaceAll_ParamsHtmlObject_AttributeToVoidElement()
        {
            HtmlElement parent = new HtmlElement("parent", isVoid: true);
            parent.Add(new HtmlAttribute("attribute"));

            HtmlAttribute[] attributes = new HtmlAttribute[] { new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2") };
            parent.ReplaceAll(attributes);
            Assert.Equal(attributes, parent.Attributes());
        }

        [Fact]
        public void ReplaceAll_IEnumerableHtmlObject_AttributeToVoidElement()
        {
            HtmlElement parent = new HtmlElement("parent", isVoid: true);
            parent.Add(new HtmlAttribute("attribute"));

            HtmlAttribute[] attributes = new HtmlAttribute[] { new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2") };
            parent.ReplaceAll((IEnumerable<HtmlObject>)attributes);
            Assert.Equal(attributes, parent.Attributes());
        }

        [Fact]
        public void ReplaceAll_NullContent_ThrowsArgumentNullException()
        {
            HtmlElement parent = new HtmlElement("parent");

            Assert.Throws<ArgumentNullException>("content", () => parent.ReplaceAll(null));
            Assert.Throws<ArgumentNullException>("content", () => parent.ReplaceAll((IEnumerable<HtmlObject>)null));
        }

        [Fact]
        public void ReplaceAll_SameElementInContent_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent");

            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAll(new HtmlObject[] { parent }));
            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAll((IEnumerable<HtmlObject>)new HtmlObject[] { parent }));
        }

        [Fact]
        public void ReplaceAll_ContentNotNodeOrAttribute_ThrowsArgumentException()
        {
            HtmlElement parent = new HtmlElement("parent");
            
            Assert.Throws<ArgumentException>("content", () => parent.ReplaceAll(new HtmlObject[] { new CustomHtmlObject() }));
            Assert.Throws<ArgumentException>("content", () => parent.ReplaceAll((IEnumerable<HtmlObject>)new HtmlObject[] { new CustomHtmlObject() }));
        }

        [Fact]
        public void ReplaceAll_DuplicateElementInContents_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement element = new HtmlElement("element");
            parent.Add(element);

            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAll(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAll((IEnumerable<HtmlObject>)new HtmlObject[] { element }));
        }

        [Fact]
        public void ReplaceAll_DuplicateAttributeInContents_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlAttribute attribute = new HtmlAttribute("attribute");
            parent.Add(attribute);

            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAll(new HtmlObject[] { attribute }));
            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAll((IEnumerable<HtmlObject>)new HtmlObject[] { attribute }));
        }

        [Fact]
        public void ReplaceAll_ElementToVoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent", isVoid: true);
            HtmlElement element = new HtmlElement("element");

            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAll(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAll((IEnumerable<HtmlObject>)new HtmlObject[] { element }));
        }

        [Theory]
        [MemberData(nameof(Attributes_TestData))]
        public void ReplaceAttributes_ParamsHtmlAttribute(HtmlAttribute[] attributes)
        {
            HtmlElement parent = new HtmlElement("parent", new HtmlElement("element"), new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2"));
            parent.ReplaceAttributes(attributes);
            Assert.Equal(1, parent.Elements().Count());
            Assert.Equal(attributes, parent.Attributes().ToArray());
            Assert.Equal(1 + attributes.Length, parent.ElementsAndAttributes().Count());
        }

        [Fact]
        public void ReplaceAttributes_ParamsHtmlAttribute_VoidElement()
        {
            HtmlElement parent = new HtmlElement("parent", isVoid: true);
            parent.Add(new HtmlAttribute("attribute"));

            HtmlAttribute[] attributes = new HtmlAttribute[] { new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2") };
            parent.ReplaceAttributes(attributes);
            Assert.Equal(attributes, parent.Attributes());
        }

        [Theory]
        [MemberData(nameof(Attributes_TestData))]
        public void ReplaceAttributes_IEnumerableHtmlAttribute(HtmlAttribute[] attributes)
        {
            HtmlElement element = new HtmlElement("parent", new HtmlElement("h1"), new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2"));
            element.ReplaceAttributes((IEnumerable<HtmlAttribute>)attributes);
            Assert.Equal(1, element.Elements().Count());
            Assert.Equal(attributes, element.Attributes().ToArray());
            Assert.Equal(1 + attributes.Length, element.ElementsAndAttributes().Count());
        }

        [Fact]
        public void ReplaceAttributes_IEnumerableHtmlAttribute_VoidElement()
        {
            HtmlElement parent = new HtmlElement("br", isVoid: true);
            parent.Add(new HtmlAttribute("attribute1"));

            HtmlAttribute[] attributes = new HtmlAttribute[] { new HtmlAttribute("attribute2"), new HtmlAttribute("c") };
            parent.ReplaceAttributes((IEnumerable<HtmlAttribute>)attributes);
            Assert.Equal(attributes, parent.Attributes());
        }

        [Fact]
        public void ReplaceAttributes_NullAttributes_ThrowsArgumentNullException()
        {
            HtmlElement parent = new HtmlElement("parent");

            Assert.Throws<ArgumentNullException>("attributes", () => parent.ReplaceAttributes(null));
            Assert.Throws<ArgumentNullException>("attributes", () => parent.ReplaceAttributes((IEnumerable<HtmlAttribute>)null));
        }

        [Fact]
        public void ReplaceAttributes_NullAttributeInAttributes_ThrowsArgumentNullException()
        {
            HtmlElement parent = new HtmlElement("parent");

            Assert.Throws<ArgumentNullException>("content", () => parent.ReplaceAttributes(new HtmlAttribute[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => parent.ReplaceAttributes((IEnumerable<HtmlAttribute>)new HtmlAttribute[] { null }));
        }

        [Fact]
        public void ReplaceAttributes_DuplicateAttributeInAttribues_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlAttribute attribute = new HtmlAttribute("attribute");
            parent.Add(attribute);

            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAttributes(new HtmlAttribute[] { attribute }));
            Assert.Throws<InvalidOperationException>(() => parent.ReplaceAttributes((IEnumerable<HtmlAttribute>)new HtmlAttribute[] { attribute }));
        }

        public static IEnumerable<object[]> Elements_TestData()
        {
            yield return new object[] { new HtmlElement[0] };
            yield return new object[] { new HtmlElement[] { new HtmlElement("element1") } };
            yield return new object[] { new HtmlElement[] { new HtmlElement("element1"), new HtmlElement("element2") } };
            yield return new object[] { new HtmlElement[] { new HtmlElement("element1"), new HtmlElement("element2"), new HtmlElement("element1") } };
        }

        [Theory]
        [MemberData(nameof(Elements_TestData))]
        public void ReplaceNodesParamsHtmlElement(HtmlElement[] elements)
        {
            HtmlElement parent = new HtmlElement("parent", new HtmlElement("element"), new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2"));

            parent.ReplaceNodes(elements);
            Assert.Equal(elements, parent.Elements().ToArray());
            Assert.Equal(2, parent.Attributes().Count());
            Assert.Equal(elements.Length + 2, parent.ElementsAndAttributes().Count());
        }

        [Theory]
        [MemberData(nameof(Elements_TestData))]
        public void ReplaceNodesIEnumerableHtmlElement(HtmlElement[] elements)
        {
            HtmlElement parent = new HtmlElement("parent", new HtmlElement("element"), new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2"));

            parent.ReplaceNodes(elements);
            Assert.Equal(elements, parent.Elements().ToArray());
            Assert.Equal(2, parent.Attributes().Count());
            Assert.Equal(elements.Length + 2, parent.ElementsAndAttributes().Count());
        }

        [Fact]
        public void ReplaceNodesNullElements_ThrowsArgumentNullException()
        {
            HtmlElement parent = new HtmlElement("parent");

            Assert.Throws<ArgumentNullException>("nodes", () => parent.ReplaceNodes(null));
            Assert.Throws<ArgumentNullException>("nodes", () => parent.ReplaceNodes((IEnumerable<HtmlNode>)null));
        }

        [Fact]
        public void ReplaceNodes_NullElementInNodes_ThrowsArgumentNullException()
        {
            HtmlElement parent = new HtmlElement("parent");

            Assert.Throws<ArgumentNullException>("content", () => parent.ReplaceNodes(new HtmlNode[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => parent.ReplaceNodes((IEnumerable<HtmlNode>)new HtmlNode[] { null }));
        }

        [Fact]
        public void ReplaceNodes_SameNodeInNodes_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("element");

            Assert.Throws<InvalidOperationException>(() => parent.ReplaceNodes(new HtmlNode[] { parent }));
            Assert.Throws<InvalidOperationException>(() => parent.ReplaceNodes((IEnumerable<HtmlNode>)new HtmlNode[] { parent }));
        }

        [Fact]
        public void ReplaceNodes_DuplicateElementInNodes_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement element = new HtmlElement("element");
            parent.Add(element);

            Assert.Throws<InvalidOperationException>(() => parent.ReplaceNodes(new HtmlNode[] { element }));
            Assert.Throws<InvalidOperationException>(() => parent.ReplaceNodes((IEnumerable<HtmlNode>)new HtmlNode[] { element }));
        }

        [Fact]
        public void ReplaceNodes_NodeToVoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent", isVoid: true);
            HtmlElement element = new HtmlElement("element");

            Assert.Throws<InvalidOperationException>(() => parent.ReplaceNodes(new HtmlNode[] { element }));
            Assert.Throws<InvalidOperationException>(() => parent.ReplaceNodes((IEnumerable<HtmlNode>)new HtmlNode[] { element }));
        }

        [Theory]
        [InlineData("InnerText")]
        [InlineData(" \t \r \n")]
        [InlineData("")]
        [InlineData(null)]
        public void SetInnerText(string innerText)
        {
            HtmlElement element = new HtmlElement("element");
            element.SetInnerText(innerText);
            Assert.Equal(innerText, element.InnerText);
        }

        [Fact]
        public void SetInnerText_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("element", isVoid: true);

            Assert.Throws<InvalidOperationException>(() => element.SetInnerText("InnerText"));
        }
    }
}
