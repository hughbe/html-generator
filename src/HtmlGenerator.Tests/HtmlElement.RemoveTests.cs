using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HtmlGenerator.Tests
{
    public partial class HtmlElementTests
    {
        [Fact]
        public void RemoveAll()
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h1"), new HtmlComment("comment"), new HtmlAttribute("a"), new HtmlAttribute("b"));

            element.RemoveAll();
            Assert.Equal(0, element.Nodes().Count());
            Assert.Equal(0, element.Attributes().Count());

            // Make sure we can remove from an empty element
            element.RemoveAll();
            Assert.Equal(0, element.Nodes().Count());
            Assert.Equal(0, element.Attributes().Count());
        }

        [Fact]
        public void RemoveAll_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html", isVoid: true);
            Assert.Throws<InvalidOperationException>(() => element.RemoveAll());
        }

        [Fact]
        public void RemoveAttributes()
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h1"), new HtmlComment("comment"), new HtmlAttribute("a"), new HtmlAttribute("b"));

            element.RemoveAttributes();
            Assert.Equal(2, element.Nodes().Count());
            Assert.Equal(0, element.Attributes().Count());

            // Make sure we can remove from an empty element
            element.RemoveAttributes();
            Assert.Equal(2, element.Nodes().Count());
            Assert.Equal(0, element.Attributes().Count());
        }

        [Fact]
        public void RemoveAttributes_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html", isVoid: true);
            Assert.Throws<InvalidOperationException>(() => element.RemoveAttributes());
        }

        [Fact]
        public void RemoveNodes()
        {
            HtmlElement element = new HtmlElement("html", new HtmlElement("h1"), new HtmlComment("comment"), new HtmlAttribute("a"), new HtmlAttribute("b"));

            element.RemoveNodes();
            Assert.Equal(0, element.Nodes().Count());
            Assert.Equal(2, element.Attributes().Count());

            // Make sure we can remove from an empty element
            element.RemoveNodes();
            Assert.Equal(0, element.Nodes().Count());
            Assert.Equal(2, element.Attributes().Count());
        }

        [Fact]
        public void RemoveNodes_VoidElement_ThrowsInvalidOperationException()
        {
            HtmlElement element = new HtmlElement("html", isVoid: true);
            Assert.Throws<InvalidOperationException>(() => element.RemoveNodes());
        }
    }
}
