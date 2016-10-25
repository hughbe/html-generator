using System;
using System.Collections.Generic;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlNodeTests
    {
        [Fact]
        public void AddAfterSelf_HtmlNode()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            parent.Add(child1);

            // Element
            HtmlElement child2 = new HtmlElement("child2");
            child1.AddAfterSelf(child2);
            Assert.Equal(parent, child2.Parent);
            Assert.Equal(new HtmlElement[] { child1, child2 }, parent.Elements());

            // Comment
            HtmlComment comment = new HtmlComment("comment");
            child1.AddAfterSelf(comment);
            Assert.Equal(parent, comment.Parent);
            Assert.Equal(new HtmlObject[] { child1, comment, child2 }, parent.Nodes());
        }

        [Fact]
        public void AddAfterSelf_ParamsHtmlObject()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            parent.Add(child1);

            // Element
            HtmlElement child2 = new HtmlElement("child2");
            HtmlElement child3 = new HtmlElement("child3");
            child1.AddAfterSelf(child2, child3);

            Assert.Equal(parent, child2.Parent);
            Assert.Equal(parent, child3.Parent);
            Assert.Equal(new HtmlElement[] { child1, child2, child3 }, parent.Elements());
        }

        [Fact]
        public void AddAfterSelf_ParamsHtmlObject_Empty()
        {
            HtmlElement parent = new HtmlElement("html");
            HtmlElement element = new HtmlElement("body");
            element.AddAfterSelf();
            Assert.Empty(parent.Elements());
            Assert.Empty(parent.Attributes());
        }

        [Fact]
        public void AddAfterSelf_IEnumerableHtmlObject()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            parent.Add(child1);

            HtmlElement child2 = new HtmlElement("child2");
            HtmlElement child3 = new HtmlElement("child3");
            child1.AddAfterSelf((IEnumerable<HtmlElement>)new HtmlElement[] { child2, child3 });

            Assert.Equal(parent, child2.Parent);
            Assert.Equal(parent, child3.Parent);
            Assert.Equal(new HtmlElement[] { child1, child2, child3 }, parent.Elements());
        }

        [Fact]
        public void AddAfterSelf_IEnumerableHtmlObject_Empty()
        {
            HtmlElement parent = new HtmlElement("html");
            HtmlElement element = new HtmlElement("body");
            element.AddAfterSelf((IEnumerable<HtmlElement>)new HtmlElement[0]);
            Assert.Empty(parent.Elements());
            Assert.Empty(parent.Attributes());
        }

        [Fact]
        public void AddAfterSelf_NullContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("element");

            Assert.Throws<ArgumentNullException>("content", () => element.AddAfterSelf((HtmlElement)null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddAfterSelf((HtmlElement[])null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddAfterSelf((IEnumerable<HtmlElement>)null));
        }

        [Fact]
        public void AddAfterSelf_NullObjectInContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("element");

            Assert.Throws<ArgumentNullException>("content", () => element.AddAfterSelf(new HtmlNode[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.AddAfterSelf((IEnumerable<HtmlNode>)new HtmlNode[] { null }));
        }

        [Fact]
        public void AddAfterSelf_SameElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");

            Assert.Throws<InvalidOperationException>(() => element.AddAfterSelf(element));
            Assert.Throws<InvalidOperationException>(() => element.AddAfterSelf(new HtmlNode[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.AddAfterSelf((IEnumerable<HtmlNode>)new HtmlNode[] { element }));
        }

        [Fact]
        public void AddAfterSelf_DuplicateElement_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement element = new HtmlElement("child");
            parent.Add(element);

            Assert.Throws<InvalidOperationException>(() => parent.AddAfterSelf(element));
            Assert.Throws<InvalidOperationException>(() => parent.AddAfterSelf(new HtmlNode[] { element }));
            Assert.Throws<InvalidOperationException>(() => parent.AddAfterSelf((IEnumerable<HtmlNode>)new HtmlNode[] { element }));
        }

        [Fact]
        public void AddAfterSelf_ElementToVoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            HtmlElement newElement = new HtmlElement("p");

            Assert.Throws<InvalidOperationException>(() => element.AddAfterSelf(newElement));
            Assert.Throws<InvalidOperationException>(() => element.AddAfterSelf(new HtmlNode[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.AddAfterSelf((IEnumerable<HtmlNode>)new HtmlNode[] { newElement }));
        }

        [Fact]
        public void AddBeforeSelf_HtmlNode()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            parent.Add(child1);

            // Element
            HtmlElement child2 = new HtmlElement("child2");
            child1.AddBeforeSelf(child2);
            Assert.Equal(parent, child2.Parent);
            Assert.Equal(new HtmlElement[] { child2, child1 }, parent.Elements());

            // Comment
            HtmlComment comment = new HtmlComment("comment");
            child1.AddBeforeSelf(comment);
            Assert.Equal(parent, comment.Parent);
            Assert.Equal(new HtmlObject[] { child2, comment, child1 }, parent.Nodes());
        }

        [Fact]
        public void AddBeforeSelf_ParamsHtmlObject()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            parent.Add(child1);

            // Element
            HtmlElement child2 = new HtmlElement("child2");
            HtmlElement child3 = new HtmlElement("child3");
            child1.AddBeforeSelf(child2, child3);

            Assert.Equal(parent, child2.Parent);
            Assert.Equal(parent, child3.Parent);
            Assert.Equal(new HtmlElement[] { child3, child2, child1 }, parent.Elements());
        }

        [Fact]
        public void AddBeforeSelf_ParamsHtmlObject_Empty()
        {
            HtmlElement parent = new HtmlElement("html");
            HtmlElement element = new HtmlElement("body");
            element.AddAfterSelf();
            Assert.Empty(parent.Elements());
            Assert.Empty(parent.Attributes());
        }

        [Fact]
        public void AddBeforeSelf_IEnumerableHtmlObject()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            parent.Add(child1);

            HtmlElement child2 = new HtmlElement("child2");
            HtmlElement child3 = new HtmlElement("child3");
            child1.AddBeforeSelf((IEnumerable<HtmlElement>)new HtmlElement[] { child2, child3 });

            Assert.Equal(parent, child2.Parent);
            Assert.Equal(parent, child3.Parent);
            Assert.Equal(new HtmlElement[] { child3, child2, child1 }, parent.Elements());
        }

        [Fact]
        public void AddBeforeSelf_IEnumerableHtmlObject_Empty()
        {
            HtmlElement parent = new HtmlElement("html");
            HtmlElement element = new HtmlElement("body");
            element.AddAfterSelf((IEnumerable<HtmlElement>)new HtmlElement[0]);
            Assert.Empty(parent.Elements());
            Assert.Empty(parent.Attributes());
        }

        [Fact]
        public void AddBeforeSelf_NullContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("element");

            Assert.Throws<ArgumentNullException>("content", () => element.AddBeforeSelf((HtmlNode)null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddBeforeSelf((HtmlNode[])null));
            Assert.Throws<ArgumentNullException>("content", () => element.AddBeforeSelf((IEnumerable<HtmlNode>)null));
        }

        [Fact]
        public void AddBeforeSelf_NullObjectInContent_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("element");

            Assert.Throws<ArgumentNullException>("content", () => element.AddBeforeSelf(new HtmlNode[] { null }));
            Assert.Throws<ArgumentNullException>("content", () => element.AddBeforeSelf((IEnumerable<HtmlNode>)new HtmlElement[] { null }));
        }

        [Fact]
        public void AddBeforeSelf_SameElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html");

            Assert.Throws<InvalidOperationException>(() => element.AddBeforeSelf(element));
            Assert.Throws<InvalidOperationException>(() => element.AddBeforeSelf(new HtmlNode[] { element }));
            Assert.Throws<InvalidOperationException>(() => element.AddBeforeSelf((IEnumerable<HtmlNode>)new HtmlNode[] { element }));
        }

        [Fact]
        public void AddBeforeSelf_DuplicateElement_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement element = new HtmlElement("child");
            parent.Add(element);

            Assert.Throws<InvalidOperationException>(() => parent.AddBeforeSelf(element));
            Assert.Throws<InvalidOperationException>(() => parent.AddBeforeSelf(new HtmlNode[] { element }));
            Assert.Throws<InvalidOperationException>(() => parent.AddBeforeSelf((IEnumerable<HtmlNode>)new HtmlNode[] { element }));
        }

        [Fact]
        public void AddBeforeSelf_ElementToVoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("br", isVoid: true);
            HtmlElement newElement = new HtmlElement("p");

            Assert.Throws<InvalidOperationException>(() => element.AddBeforeSelf(newElement));
            Assert.Throws<InvalidOperationException>(() => element.AddBeforeSelf(new HtmlNode[] { newElement }));
            Assert.Throws<InvalidOperationException>(() => element.AddBeforeSelf((IEnumerable<HtmlNode>)new HtmlNode[] { newElement }));
        }

        [Fact]
        public void NextNode_Get_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, element2);
            Assert.True(parent.HasElements);

            Assert.Equal(comment, element1.NextNode);
            Assert.Equal(element2, comment.NextNode);
            Assert.Null(element2.NextNode);
        }

        [Fact]
        public void NextNode_IgnoresAttributes()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, new HtmlAttribute("attribute"), element2);
            Assert.True(parent.HasElements);

            Assert.Equal(element2, comment.NextNode);
        }

        [Fact]
        public void NextNode_NoParent_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Null(element.NextNode);
        }

        [Fact]
        public void NextNodes_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, element2);
            Assert.True(parent.HasElements);

            Assert.Equal(new HtmlNode[] { comment, element2 }, element1.NextNodes());
            Assert.Equal(new HtmlNode[] { element2 }, comment.NextNodes());
            Assert.Empty(element2.NextNodes());
        }

        [Fact]
        public void NextNodes_IgnoresAttributes()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, new HtmlAttribute("attribute"), element2);
            Assert.True(parent.HasElements);

            Assert.Equal(new HtmlElement[] { element2 }, comment.NextNodes());
        }

        [Fact]
        public void NextNodes_NoParent_ReturnsEmpty()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Empty(element.NextNodes());
        }

        [Fact]
        public void PreviousNode_Get_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, element2);
            Assert.True(parent.HasElements);

            Assert.Null(element1.PreviousNode);
            Assert.Equal(element1, comment.PreviousNode);
            Assert.Equal(comment, element2.PreviousNode);
        }

        [Fact]
        public void PreviousNode_IgnoresAttributes()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, new HtmlAttribute("attribute"), element2);
            Assert.True(parent.HasElements);

            Assert.Equal(comment, element2.PreviousNode);
        }

        [Fact]
        public void PreviousNode_NoParent_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Null(element.PreviousNode);
        }

        [Fact]
        public void PreviousNodes_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, element2);
            Assert.True(parent.HasElements);

            Assert.Empty(element1.PreviousNodes());
            Assert.Equal(new HtmlNode[] { element1 }, comment.PreviousNodes());
            Assert.Equal(new HtmlNode[] { comment, element1 }, element2.PreviousNodes());
        }

        [Fact]
        public void PreviousNodes_IgnoresAttributes()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, new HtmlAttribute("attribute"), element2);
            Assert.True(parent.HasElements);

            Assert.Equal(new HtmlNode[] { comment, element1 }, element2.PreviousNodes());
        }

        [Fact]
        public void PreviousNodes_NoParent_ReturnsEmpty()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Empty(element.PreviousNodes());
        }

        [Fact]
        public void RemoveFromParent_OnlyChild_Works()
        {
            HtmlElement child = new HtmlElement("h1");
            HtmlElement parent = new HtmlElement("div", child);

            child.RemoveFromParent();
            Assert.Null(child.Parent);
            Assert.Empty(parent.Elements());
            Assert.False(parent.HasElements);
        }

        [Fact]
        public void RemoveFromParent_FirstChild_Works()
        {
            HtmlElement child1 = new HtmlElement("h1");
            HtmlElement child2 = new HtmlElement("h2");
            HtmlElement child3 = new HtmlElement("h3");
            HtmlElement parent = new HtmlElement("div", child1, child2, child3);

            // Updates Elements
            child1.RemoveFromParent();
            Assert.Null(child1.Parent);
            Assert.Equal(new HtmlElement[] { child2, child3 }, parent.Elements());
            Assert.True(parent.HasElements);

            // Updates LinkedList
            Assert.Null(child1.PreviousNode);
            Assert.Null(child1.NextNode);

            Assert.Null(child2.PreviousNode);
            Assert.Equal(child3, child2.NextNode);

            Assert.Equal(child2, child3.PreviousNode);
            Assert.Null(child3.NextNode);
        }

        [Fact]
        public void RemoveFromParent_LastChild_Works()
        {
            HtmlElement child1 = new HtmlElement("h1");
            HtmlElement child2 = new HtmlElement("h2");
            HtmlElement child3 = new HtmlElement("h3");
            HtmlElement parent = new HtmlElement("div", child1, child2, child3);

            // Updates Elements
            child3.RemoveFromParent();
            Assert.Null(child3.Parent);
            Assert.Equal(new HtmlElement[] { child1, child2 }, parent.Elements());
            Assert.True(parent.HasElements);

            // Updates LinkedList
            Assert.Null(child1.PreviousNode);
            Assert.Equal(child2, child1.NextNode);

            Assert.Equal(child1, child2.PreviousNode);
            Assert.Null(child2.NextNode);

            Assert.Null(child3.PreviousNode);
            Assert.Null(child3.NextNode);
        }

        [Fact]
        public void RemoveFromParent_MiddleChild_Works()
        {
            HtmlElement child1 = new HtmlElement("h1");
            HtmlElement child2 = new HtmlElement("h2");
            HtmlElement child3 = new HtmlElement("h3");
            HtmlElement parent = new HtmlElement("div", child1, child2, child3);

            // Updates Elements
            child2.RemoveFromParent();
            Assert.Null(child2.Parent);
            Assert.Equal(new HtmlElement[] { child1, child3 }, parent.Elements());
            Assert.True(parent.HasElements);

            // Updates LinkedList
            Assert.Null(child1.PreviousNode);
            Assert.Equal(child3, child1.NextNode);

            Assert.Null(child2.PreviousNode);
            Assert.Null(child2.NextNode);

            Assert.Equal(child1, child3.PreviousNode);
            Assert.Null(child3.NextNode);
        }

        [Fact]
        public void RemoveFromParent_NoParent_DoesNothing()
        {
            HtmlElement element = new HtmlElement("html");
            element.RemoveFromParent();

            Assert.Null(element.Parent);
        }
    }
}
