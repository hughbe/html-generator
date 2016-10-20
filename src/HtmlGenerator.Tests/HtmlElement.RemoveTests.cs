using System;
using System.Linq;
using Xunit;

namespace HtmlGenerator.Tests
{
    public partial class HtmlElementTests
    {
        [Fact]
        public void RemoveAll_NonVoidElement()
        {
            HtmlElement parent = new HtmlElement("parent", new HtmlElement("element"), new HtmlComment("comment"), new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2"));

            parent.RemoveAll();
            Assert.Equal(0, parent.Nodes().Count());
            Assert.Equal(0, parent.Attributes().Count());

            // Make sure we can remove from an empty element
            parent.RemoveAll();
            Assert.Equal(0, parent.Nodes().Count());
            Assert.Equal(0, parent.Attributes().Count());
        }

        [Fact]
        public void RemoveAll_VoidElement()
        {
            HtmlElement parent = new HtmlElement("parent", new HtmlAttribute("attribute"));

            parent.RemoveAll();
            Assert.Equal(0, parent.Nodes().Count());
            Assert.Equal(0, parent.Attributes().Count());
        }

        [Fact]
        public void RemoveAttributes()
        {
            HtmlElement parent = new HtmlElement("parent", new HtmlElement("element"), new HtmlComment("comment"), new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2"));

            parent.RemoveAttributes();
            Assert.Equal(2, parent.Nodes().Count());
            Assert.Equal(0, parent.Attributes().Count());

            // Make sure we can remove from an empty element
            parent.RemoveAttributes();
            Assert.Equal(2, parent.Nodes().Count());
            Assert.Equal(0, parent.Attributes().Count());
        }

        [Fact]
        public void RemoveAttributes_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent", isVoid: true);
            Assert.Throws<InvalidOperationException>(() => parent.RemoveAttributes());
        }

        [Fact]
        public void RemoveNodes()
        {
            HtmlElement parent = new HtmlElement("parent", new HtmlElement("element"), new HtmlComment("comment"), new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2"));

            parent.RemoveNodes();
            Assert.Equal(0, parent.Nodes().Count());
            Assert.Equal(2, parent.Attributes().Count());

            // Make sure we can remove from an empty element
            parent.RemoveNodes();
            Assert.Equal(0, parent.Nodes().Count());
            Assert.Equal(2, parent.Attributes().Count());
        }

        [Fact]
        public void RemoveNodes_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement parent = new HtmlElement("parent", isVoid: true);

            Assert.Throws<InvalidOperationException>(() => parent.RemoveNodes());
        }
    }
}
