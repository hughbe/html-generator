using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HtmlGenerator.Tests
{
    public partial class HtmlElementTests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Add_HtmlObject(bool isVoid)
        {
            HtmlElement element = new HtmlElement("html", isVoid);

            // Atribute
            HtmlAttribute attribute = new HtmlAttribute("attribute1");
            element.Add(attribute);
            Assert.Equal(element, attribute.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute }, element.Attributes());

            if (!isVoid)
            {
                // Element
                HtmlElement newElement = new HtmlElement("body");
                element.Add(newElement);
                Assert.Equal(element, newElement.Parent);
                Assert.Equal(new HtmlElement[] { newElement }, element.Elements());

                // Comment
                HtmlComment newComment = new HtmlComment("comment");
                element.Add(newComment);
                Assert.Equal(element, newComment.Parent);
                Assert.Equal(new HtmlObject[] { newElement, newComment }, element.Nodes());
            }
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void AddFirst_HtmlObject(bool isVoid)
        {
            HtmlElement element = new HtmlElement("html", isVoid);
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            element.Add(attribute1);

            // Attribute
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            element.AddFirst(attribute2);
            Assert.Equal(element, attribute2.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute2, attribute1 }, element.Attributes());

            if (!isVoid)
            {
                HtmlElement newelement1 = new HtmlElement("body");
                element.Add(newelement1);

                // Element
                HtmlElement newelement2 = new HtmlElement("head");
                element.AddFirst(newelement2);
                Assert.Equal(element, newelement2.Parent);
                Assert.Equal(new HtmlElement[] { newelement2, newelement1 }, element.Elements());

                // Comment
                HtmlComment newComment = new HtmlComment("comment");
                element.AddFirst(newComment);
                Assert.Equal(element, newComment.Parent);
                Assert.Equal(new HtmlObject[] { newComment, newelement2, newelement1 }, element.Nodes());
            }
        }

        [Fact]
        public void Add_ParamsHtmlObject_NonVoidElement()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlElement newElement = new HtmlElement("body");
            HtmlAttribute newAttribute = new HtmlAttribute("Attribute");
            HtmlComment newComment = new HtmlComment("comment");
            element.Add(new HtmlObject[] { newElement, newAttribute, newComment });

            Assert.Equal(element, newElement.Parent);
            Assert.Equal(element, newAttribute.Parent);
            Assert.Equal(new HtmlObject[] { newElement }, element.Elements());
            Assert.Equal(new HtmlAttribute[] { newAttribute }, element.Attributes());
            Assert.Equal(new HtmlObject[] { newElement, newComment }, element.Nodes());
        }

        [Fact]
        public void AddFirst_ParamsHtmlObject_NonVoidElement()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlElement newelement1 = new HtmlElement("body");
            HtmlAttribute newAttribute1 = new HtmlAttribute("attribute1");
            element.Add(new HtmlObject[] { newelement1, newAttribute1 });

            HtmlElement newelement2 = new HtmlElement("head");
            HtmlAttribute newAttribute2 = new HtmlAttribute("attribute2");
            element.AddFirst(new HtmlObject[] { newelement2, newAttribute2 });

            Assert.Equal(element, newelement2.Parent);
            Assert.Equal(element, newAttribute2.Parent);
            Assert.Equal(new HtmlObject[] { newelement2, newelement1 }, element.Elements());
            Assert.Equal(new HtmlAttribute[] { newAttribute2, newAttribute1 }, element.Attributes());
        }

        [Fact]
        public void Add_ParamsHtmlObject_VoidElement()
        {
            HtmlElement element = new HtmlElement("html", isVoid: true);
            HtmlAttribute newAttribute1 = new HtmlAttribute("attribute1");
            HtmlAttribute newAttribute2 = new HtmlAttribute("attribute2");
            element.Add(new HtmlObject[] { newAttribute1, newAttribute2 });

            Assert.Equal(element, newAttribute1.Parent);
            Assert.Equal(element, newAttribute2.Parent);
            Assert.Empty(element.Elements());
            Assert.Equal(new HtmlAttribute[] { newAttribute1, newAttribute2 }, element.Attributes());
        }

        [Fact]
        public void AddFirst_ParamsHtmlObject_VoidElement()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlAttribute newAttribute1 = new HtmlAttribute("attribute1");
            element.Add(newAttribute1);

            HtmlAttribute newAttribute2 = new HtmlAttribute("attribute2");
            HtmlAttribute newAttribute3 = new HtmlAttribute("attribute3");
            element.AddFirst(new HtmlObject[] { newAttribute2, newAttribute3 });

            Assert.Equal(element, newAttribute2.Parent);
            Assert.Equal(element, newAttribute3.Parent);
            Assert.Empty(element.Elements());
            Assert.Equal(new HtmlAttribute[] { newAttribute3, newAttribute2, newAttribute1 }, element.Attributes());
        }

        [Fact]
        public void Add_ParamsHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("html");
            element.Add(new HtmlObject[0]);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
        }

        [Fact]
        public void AddFirst_ParamsHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("html");
            element.AddFirst(new HtmlObject[0]);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
        }

        [Fact]
        public void Add_IEnumerableHtmlObject_NonVoidElement()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlElement newElement = new HtmlElement("body");
            HtmlAttribute newAttribute = new HtmlAttribute("Attribute");
            element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { newElement, newAttribute });

            Assert.Equal(element, newElement.Parent);
            Assert.Equal(element, newAttribute.Parent);
            Assert.Equal(new HtmlObject[] { newElement }, element.Elements());
            Assert.Equal(new HtmlAttribute[] { newAttribute }, element.Attributes());
        }

        [Fact]
        public void AddFirst_IEnumerableHtmlObject_NonVoidElement()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlElement newelement1 = new HtmlElement("body");
            HtmlAttribute newAttribute1 = new HtmlAttribute("attribute1");
            element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { newelement1, newAttribute1 });

            HtmlElement newelement2 = new HtmlElement("head");
            HtmlAttribute newAttribute2 = new HtmlAttribute("attribute2");
            element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { newelement2, newAttribute2 });

            Assert.Equal(element, newelement2.Parent);
            Assert.Equal(element, newAttribute2.Parent);
            Assert.Equal(new HtmlObject[] { newelement2, newelement1 }, element.Elements());
            Assert.Equal(new HtmlAttribute[] { newAttribute2, newAttribute1 }, element.Attributes());
        }

        [Fact]
        public void Add_IEnumerableHtmlObject_VoidElement()
        {
            HtmlElement element = new HtmlElement("html", isVoid: true);
            HtmlAttribute newAttribute1 = new HtmlAttribute("attribute1");
            HtmlAttribute newAttribute2 = new HtmlAttribute("attribute2");
            element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute1, newAttribute2 });

            Assert.Equal(element, newAttribute1.Parent);
            Assert.Equal(element, newAttribute2.Parent);
            Assert.Empty(element.Elements());
            Assert.Equal(new HtmlAttribute[] { newAttribute1, newAttribute2 }, element.Attributes());
        }

        [Fact]
        public void AddFirst_IEnumerableHtmlObject_VoidElement()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlAttribute newAttribute1 = new HtmlAttribute("attribute1");
            element.Add(newAttribute1);

            HtmlAttribute newAttribute2 = new HtmlAttribute("attribute2");
            HtmlAttribute newAttribute3 = new HtmlAttribute("attribute3");
            element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute2, newAttribute3 });

            Assert.Equal(element, newAttribute2.Parent);
            Assert.Equal(element, newAttribute3.Parent);
            Assert.Empty(element.Elements());
            Assert.Equal(new HtmlAttribute[] { newAttribute3, newAttribute2, newAttribute1 }, element.Attributes());
        }

        [Fact]
        public void Add_IEnumerableHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("html");
            element.Add(new HtmlObject[0]);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
        }

        [Fact]
        public void AddFirst_IEnumerableHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("html");
            element.AddFirst(new HtmlObject[0]);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
        }

        [Fact]
        public void Add_NullContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<ArgumentNullException>("content", () => element.Add((HtmlObject)null));
            Assert.Throws<ArgumentNullException>("content", () => element.Add((HtmlObject[])null));
            Assert.Throws<ArgumentNullException>("content", () => element.Add((IEnumerable<HtmlObject>)null));

            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((HtmlObject)null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((HtmlObject[])null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((IEnumerable<HtmlObject>)null));
        }

        [Fact]
        public void Add_NullObjectInContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<ArgumentNullException>("content", () => element.Add(new HtmlObject[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { null }));

            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst(new HtmlObject[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { null }));
        }

        [Fact]
        public void Add_SameElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<InvalidOperationException>(() => element.Add(element));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { element }));

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { element }));
        }

        [Fact]
        public void Add_DuplicateElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlElement newElement = new HtmlElement("body");
            element.Add(newElement);

            Assert.Throws<InvalidOperationException>(() => element.Add(newElement));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlElement>)new HtmlElement[] { newElement }));

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newElement));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlElement>)new HtmlElement[] { newElement }));
        }

        [Fact]
        public void Add_DuplicateAttribute_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlAttribute newAttribute = new HtmlAttribute("Attribute");
            element.Add(newAttribute);

            Assert.Throws<InvalidOperationException>(() => element.Add(newAttribute));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute }));

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newAttribute));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute }));
        }

        [Fact]
        public void Add_EqualAttribute_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlAttribute attribute = new HtmlAttribute("Attribute");
            element.Add(attribute);

            HtmlAttribute newAttribute = new HtmlAttribute(attribute.Name);

            Assert.Throws<InvalidOperationException>(() => element.Add(newAttribute));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute }));

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newAttribute));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute }));
        }

        [Fact]
        public void Add_ElementToVoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            HtmlElement newElement = new HtmlElement("p");

            Assert.Throws<InvalidOperationException>(() => element.Add(newElement));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { newElement }));

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newElement));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { newElement }));
        }

        [Fact]
        public void Add_ElementHasDifferentParent_RemovesFromOldParent()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            HtmlElement granchild1 = new HtmlElement("grandchild1");
            HtmlElement granchild2 = new HtmlElement("grandchild2");
            HtmlElement granchild3 = new HtmlElement("grandchild3");
            HtmlElement child2 = new HtmlElement("child2");

            parent.Add(child1, child2);
            child1.Add(granchild1, granchild2, granchild3);

            child2.Add(granchild1);
            Assert.Equal(child2, granchild1.Parent);
            Assert.Equal(new HtmlElement[] { granchild1 }, child2.Elements());
            Assert.Equal(new HtmlElement[] { granchild2, granchild3 }, child1.Elements());

            child2.Add(granchild2);
            Assert.Equal(child2, granchild2.Parent);
            Assert.Equal(new HtmlElement[] { granchild1, granchild2 }, child2.Elements());
            Assert.Equal(new HtmlElement[] { granchild3 }, child1.Elements());

            child2.Add(granchild3);
            Assert.Equal(child2, granchild3.Parent);
            Assert.Equal(new HtmlElement[] { granchild1, granchild2, granchild3 }, child2.Elements());
            Assert.Empty(child1.Elements());
        }

        [Fact]
        public void Add_AttributeHasDifferentParent_RemovesFromOldParent()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            HtmlAttribute attribute3 = new HtmlAttribute("attribute3");
            HtmlElement child2 = new HtmlElement("child2");

            parent.Add(child1, child2);
            child1.Add(attribute1, attribute2, attribute3);

            child2.Add(attribute1);
            Assert.Equal(child2, attribute1.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute1 }, child2.Attributes());
            Assert.Equal(new HtmlAttribute[] { attribute2, attribute3 }, child1.Attributes());

            child2.Add(attribute2);
            Assert.Equal(child2, attribute2.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute1, attribute2 }, child2.Attributes());
            Assert.Equal(new HtmlAttribute[] { attribute3 }, child1.Attributes());

            child2.Add(attribute3);
            Assert.Equal(child2, attribute3.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute1, attribute2, attribute3 }, child2.Attributes());
            Assert.Empty(child1.Attributes());
        }

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

        [Fact]
        public void RemoveAll()
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h1"), new HtmlAttribute("a"), new HtmlAttribute("b"));

            element.RemoveAll();
            Assert.Equal(0, element.Elements().Count());
            Assert.Equal(0, element.Attributes().Count());

            // Make sure we can remove from an empty element
            element.RemoveAll();
            Assert.Equal(0, element.Elements().Count());
            Assert.Equal(0, element.Attributes().Count());
        }

        [Fact]
        public void RemoveAll_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html", isVoid: true);
            Assert.Throws<InvalidOperationException>(() => element.RemoveAll());
        }

        [Fact]
        public void RemoveElements()
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h1"), new HtmlAttribute("a"), new HtmlAttribute("b"));

            element.RemoveElements();
            Assert.Equal(0, element.Elements().Count());
            Assert.Equal(2, element.Attributes().Count());

            // Make sure we can remove from an empty element
            element.RemoveElements();
            Assert.Equal(0, element.Elements().Count());
            Assert.Equal(2, element.Attributes().Count());
        }

        [Fact]
        public void RemoveElements_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html", isVoid: true);
            Assert.Throws<InvalidOperationException>(() => element.RemoveElements());
        }

        [Fact]
        public void RemoveAttributes()
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h1"), new HtmlAttribute("a"), new HtmlAttribute("b"));

            element.RemoveAttributes();
            Assert.Equal(1, element.Elements().Count());
            Assert.Equal(0, element.Attributes().Count());

            // Make sure we can remove from an empty element
            element.RemoveAttributes();
            Assert.Equal(1, element.Elements().Count());
            Assert.Equal(0, element.Attributes().Count());
        }

        [Fact]
        public void RemoveAttributes_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html", isVoid: true);
            Assert.Throws<InvalidOperationException>(() => element.RemoveAttributes());
        }
    }
}
