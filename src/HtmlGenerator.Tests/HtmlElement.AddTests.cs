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
        public void Add_ParamsHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("html");
            element.Add(new HtmlObject[0]);
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
        public void Add_IEnumerableHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("html");
            element.Add(new HtmlObject[0]);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
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

        [Fact]
        public void Add_NullContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");

            Assert.Throws<ArgumentNullException>("content", () => element.Add((HtmlObject)null));
            Assert.Throws<ArgumentNullException>("content", () => element.Add((HtmlObject[])null));
            Assert.Throws<ArgumentNullException>("content", () => element.Add((IEnumerable<HtmlObject>)null));
        }

        [Fact]
        public void Add_NullObjectInContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<ArgumentNullException>("content", () => element.Add(new HtmlObject[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { null }));
        }

        [Fact]
        public void Add_SameElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Throws<InvalidOperationException>(() => element.Add(element));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { element }));        }

        [Fact]
        public void Add_DuplicateElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlElement newElement = new HtmlElement("body");
            element.Add(newElement);

            Assert.Throws<InvalidOperationException>(() => element.Add(newElement));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlElement>)new HtmlElement[] { newElement }));
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
        }

        [Fact]
        public void Add_ElementToVoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            HtmlElement newElement = new HtmlElement("p");

            Assert.Throws<InvalidOperationException>(() => element.Add(newElement));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { newElement }));
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
        public void AddFirst_ParamsHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("html");
            element.AddFirst(new HtmlObject[0]);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
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
        public void AddFirst_IEnumerableHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("html");
            element.AddFirst(new HtmlObject[0]);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
        }

        [Fact]
        public void AddFirst_ElementHasDifferentParent_RemovesFromOldParent()
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
        public void AddFirst_AttributeHasDifferentParent_RemovesFromOldParent()
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

        [Fact]
        public void AddFirst_NullContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");

            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((HtmlObject)null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((HtmlObject[])null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((IEnumerable<HtmlObject>)null));
        }

        [Fact]
        public void AddFirst_NullObjectInContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("html");

            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst(new HtmlObject[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { null }));
        }

        [Fact]
        public void AddFirst_SameElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(element));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { element }));
        }

        [Fact]
        public void AddFirst_DuplicateElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlElement newElement = new HtmlElement("body");
            element.Add(newElement);
            
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newElement));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlElement>)new HtmlElement[] { newElement }));
        }

        [Fact]
        public void AddFirst_DuplicateAttribute_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlAttribute newAttribute = new HtmlAttribute("Attribute");
            element.Add(newAttribute);

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newAttribute));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute }));
        }

        [Fact]
        public void AddFirst_EqualAttribute_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");
            HtmlAttribute attribute = new HtmlAttribute("Attribute");
            element.Add(attribute);
            HtmlAttribute newAttribute = new HtmlAttribute(attribute.Name);

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newAttribute));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute }));
        }

        [Fact]
        public void AddFirst_ElementToVoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            HtmlElement newElement = new HtmlElement("p");

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newElement));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { newElement }));
        }
    }
}
