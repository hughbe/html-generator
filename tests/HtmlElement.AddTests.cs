using System;
using System.Collections.Generic;
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
            HtmlElement parent = new HtmlElement("parent", isVoid);

            // Atribute
            HtmlAttribute attribute = new HtmlAttribute("attribute");
            parent.Add(attribute);
            Assert.Equal(parent, attribute.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute }, parent.Attributes());

            if (!isVoid)
            {
                // Element
                HtmlElement element = new HtmlElement("element");
                parent.Add(element);
                Assert.Equal(parent, element.Parent);
                Assert.Equal(new HtmlElement[] { element }, parent.Elements());

                // Nodes
                HtmlComment comment = new HtmlComment("comment");
                parent.Add(comment);
                Assert.Equal(parent, comment.Parent);
                Assert.Equal(new HtmlObject[] { element, comment }, parent.Nodes());
            }
        }

        [Fact]
        public void Add_ParamsHtmlObject_NonVoidElement()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement element = new HtmlElement("element");
            HtmlAttribute attribute = new HtmlAttribute("attribute");
            HtmlComment comment = new HtmlComment("comment");
            parent.Add(new HtmlObject[] { element, attribute, comment });

            Assert.Equal(parent, element.Parent);
            Assert.Equal(parent, attribute.Parent);
            Assert.Equal(new HtmlObject[] { element }, parent.Elements());
            Assert.Equal(new HtmlAttribute[] { attribute }, parent.Attributes());
            Assert.Equal(new HtmlObject[] { element, comment }, parent.Nodes());
        }

        [Fact]
        public void Add_ParamsHtmlObject_VoidElement()
        {
            HtmlElement element = new HtmlElement("parent", isVoid: true);
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            element.Add(new HtmlObject[] { attribute1, attribute2 });

            Assert.Equal(element, attribute1.Parent);
            Assert.Equal(element, attribute2.Parent);
            Assert.Empty(element.Elements());
            Assert.Equal(new HtmlAttribute[] { attribute1, attribute2 }, element.Attributes());
        }

        [Fact]
        public void Add_ParamsHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("parent");
            element.Add(new HtmlObject[0]);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
        }

        [Fact]
        public void Add_IEnumerableHtmlObject_NonVoidElement()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement element = new HtmlElement("element");
            HtmlAttribute attribute = new HtmlAttribute("Attribute");
            parent.Add((IEnumerable<HtmlObject>)new HtmlObject[] { element, attribute });

            Assert.Equal(parent, element.Parent);
            Assert.Equal(parent, attribute.Parent);
            Assert.Equal(new HtmlObject[] { element }, parent.Elements());
            Assert.Equal(new HtmlAttribute[] { attribute }, parent.Attributes());
        }

        [Fact]
        public void Add_IEnumerableHtmlObject_VoidElement()
        {
            HtmlElement parent = new HtmlElement("parent", isVoid: true);
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            parent.Add((IEnumerable<HtmlObject>)new HtmlObject[] { attribute1, attribute2 });

            Assert.Equal(parent, attribute1.Parent);
            Assert.Equal(parent, attribute2.Parent);
            Assert.Empty(parent.Elements());
            Assert.Equal(new HtmlAttribute[] { attribute1, attribute2 }, parent.Attributes());
        }

        [Fact]
        public void Add_IEnumerableHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("parent");
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
            HtmlElement element = new HtmlElement("parent");

            Assert.Throws<ArgumentNullException>("content", () => element.Add((HtmlObject)null));
            Assert.Throws<ArgumentNullException>("content", () => element.Add((HtmlObject[])null));
            Assert.Throws<ArgumentNullException>("content", () => element.Add((IEnumerable<HtmlObject>)null));
        }

        [Fact]
        public void Add_NullObjectInContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.Throws<ArgumentNullException>("content", () => element.Add(new HtmlObject[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { null }));
        }

        [Fact]
        public void Add_ContentNotNodeOrAttribute_ThrowsArgumentException()
        {
            HtmlElement element = new HtmlElement("parent");

            Assert.Throws<ArgumentException>("content", () => element.Add(new CustomHtmlObject()));
            Assert.Throws<ArgumentException>("content", () => element.Add(new HtmlObject[] { new CustomHtmlObject() }));
            Assert.Throws<ArgumentException>("content", () => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { new CustomHtmlObject() }));
        }

        [Fact]
        public void Add_SameElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.Throws<InvalidOperationException>(() => element.Add(element));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { element }));        }

        [Fact]
        public void Add_DuplicateElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("parent");
            HtmlElement newElement = new HtmlElement("body");
            element.Add(newElement);

            Assert.Throws<InvalidOperationException>(() => element.Add(newElement));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlElement>)new HtmlElement[] { newElement }));
        }

        [Fact]
        public void Add_DuplicateAttribute_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("parent");
            HtmlAttribute newAttribute = new HtmlAttribute("Attribute");
            element.Add(newAttribute);

            Assert.Throws<InvalidOperationException>(() => element.Add(newAttribute));
            Assert.Throws<InvalidOperationException>(() => element.Add(new HtmlObject[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute }));
        }

        [Fact]
        public void Add_EqualAttribute_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("parent");
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
            HtmlElement parent = new HtmlElement("parent", isVoid: true);
            HtmlElement element = new HtmlElement("element");

            Assert.Throws<InvalidOperationException>(() => parent.Add(element));
            Assert.Throws<InvalidOperationException>(() => parent.Add(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => parent.Add((IEnumerable<HtmlObject>)new HtmlObject[] { element }));
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void AddFirst_NonEmptyHtmlObject(bool isVoid)
        {
            HtmlElement parent = new HtmlElement("parent", isVoid);
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            parent.Add(attribute1);

            // Attributes
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            parent.AddFirst(attribute2);
            Assert.Equal(parent, attribute2.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute2, attribute1 }, parent.Attributes());

            if (!isVoid)
            {
                HtmlElement element1 = new HtmlElement("element1");
                parent.Add(element1);

                // Elements
                HtmlElement element2 = new HtmlElement("element2");
                parent.AddFirst(element2);
                Assert.Equal(parent, element2.Parent);
                Assert.Equal(new HtmlElement[] { element2, element1 }, parent.Elements());

                // Nodes
                HtmlComment comment = new HtmlComment("comment");
                parent.AddFirst(comment);
                Assert.Equal(parent, comment.Parent);
                Assert.Equal(new HtmlObject[] { comment, element2, element1 }, parent.Nodes());
            }
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void AddFirst_EmptyHtmlObject(bool isVoid)
        {
            HtmlElement parent = new HtmlElement("parent", isVoid);

            // Attributes
            HtmlAttribute attribute = new HtmlAttribute("attribute1");
            parent.AddFirst(attribute);
            Assert.Equal(parent, attribute.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute }, parent.Attributes());

            if (!isVoid)
            {
                // Elements
                HtmlElement element = new HtmlElement("element1");
                parent.AddFirst(element);
                Assert.Equal(parent, element.Parent);
                Assert.Equal(new HtmlElement[] { element }, parent.Elements());

                // Nodes
                HtmlComment comment = new HtmlComment("comment");
                parent.AddFirst(comment);
                Assert.Equal(parent, comment.Parent);
                Assert.Equal(new HtmlObject[] { comment, element }, parent.Nodes());
            }
        }

        [Fact]
        public void AddFirst_ParamsHtmlObject_NonVoidElement()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement element1 = new HtmlElement("body");
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            parent.Add(new HtmlObject[] { element1, attribute1 });

            HtmlElement element2 = new HtmlElement("head");
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            parent.AddFirst(new HtmlObject[] { element2, attribute2 });

            Assert.Equal(parent, element2.Parent);
            Assert.Equal(parent, attribute2.Parent);
            Assert.Equal(new HtmlObject[] { element2, element1 }, parent.Elements());
            Assert.Equal(new HtmlAttribute[] { attribute2, attribute1 }, parent.Attributes());
        }

        [Fact]
        public void AddFirst_ParamsHtmlObject_VoidElement()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlAttribute newAttribute1 = new HtmlAttribute("attribute1");
            parent.Add(newAttribute1);

            HtmlAttribute newAttribute2 = new HtmlAttribute("attribute2");
            HtmlAttribute newAttribute3 = new HtmlAttribute("attribute3");
            parent.AddFirst(new HtmlObject[] { newAttribute2, newAttribute3 });

            Assert.Equal(parent, newAttribute2.Parent);
            Assert.Equal(parent, newAttribute3.Parent);
            Assert.Empty(parent.Elements());
            Assert.Equal(new HtmlAttribute[] { newAttribute3, newAttribute2, newAttribute1 }, parent.Attributes());
        }

        [Fact]
        public void AddFirst_ParamsHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("parent");
            element.AddFirst(new HtmlObject[0]);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
        }

        [Fact]
        public void AddFirst_IEnumerableHtmlObject_NonVoidElement()
        {
            HtmlElement element = new HtmlElement("parent");
            HtmlElement element1 = new HtmlElement("body");
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            element.Add((IEnumerable<HtmlObject>)new HtmlObject[] { element1, attribute1 });

            HtmlElement element2 = new HtmlElement("head");
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { element2, attribute2 });

            Assert.Equal(element, element2.Parent);
            Assert.Equal(element, attribute2.Parent);
            Assert.Equal(new HtmlObject[] { element2, element1 }, element.Elements());
            Assert.Equal(new HtmlAttribute[] { attribute2, attribute1 }, element.Attributes());
        }

        [Fact]
        public void AddFirst_IEnumerableHtmlObject_VoidElement()
        {
            HtmlElement element = new HtmlElement("parent");
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            element.Add(attribute1);

            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            HtmlAttribute attribute3 = new HtmlAttribute("attribute3");
            element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { attribute2, attribute3 });

            Assert.Equal(element, attribute2.Parent);
            Assert.Equal(element, attribute3.Parent);
            Assert.Empty(element.Elements());
            Assert.Equal(new HtmlAttribute[] { attribute3, attribute2, attribute1 }, element.Attributes());
        }

        [Fact]
        public void AddFirst_IEnumerableHtmlObject_Empty()
        {
            HtmlElement element = new HtmlElement("parent");
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
            HtmlElement element = new HtmlElement("parent");

            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((HtmlObject)null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((HtmlObject[])null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((IEnumerable<HtmlObject>)null));
        }

        [Fact]
        public void AddFirst_NullObjectInContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("parent");

            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst(new HtmlObject[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { null }));
        }

        [Fact]
        public void AddFirst_ContentNotNodeOrAttribute_ThrowsArgumentException()
        {
            HtmlElement element = new HtmlElement("parent");

            Assert.Throws<ArgumentException>("content", () => element.AddFirst(new CustomHtmlObject()));
            Assert.Throws<ArgumentException>("content", () => element.AddFirst(new HtmlObject[] { new CustomHtmlObject() }));
            Assert.Throws<ArgumentException>("content", () => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { new CustomHtmlObject() }));
        }

        [Fact]
        public void AddFirst_SameElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("parent");

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(element));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { element }));
        }

        [Fact]
        public void AddFirst_DuplicateElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("parent");
            HtmlElement newElement = new HtmlElement("body");
            element.Add(newElement);
            
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newElement));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlElement>)new HtmlElement[] { newElement }));
        }

        [Fact]
        public void AddFirst_DuplicateAttribute_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("parent");
            HtmlAttribute newAttribute = new HtmlAttribute("Attribute");
            element.Add(newAttribute);

            Assert.Throws<InvalidOperationException>(() => element.AddFirst(newAttribute));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst(new HtmlObject[] { newAttribute }));
            Assert.Throws<InvalidOperationException>(() => element.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { newAttribute }));
        }

        [Fact]
        public void AddFirst_EqualAttribute_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("parent");
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
            HtmlElement parent = new HtmlElement("parent", isVoid: true);
            HtmlElement element = new HtmlElement("element");

            Assert.Throws<InvalidOperationException>(() => parent.AddFirst(element));
            Assert.Throws<InvalidOperationException>(() => parent.AddFirst(new HtmlObject[] { element }));
            Assert.Throws<InvalidOperationException>(() => parent.AddFirst((IEnumerable<HtmlObject>)new HtmlObject[] { element }));
        }
    }
}
