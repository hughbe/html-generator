using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HtmlGenerator.Tests
{
    public partial class HtmlElementTests
    {
        [Theory]
        [InlineData("html", "html")]
        [InlineData("HtMl", "html")]
        [InlineData("no-such-tag", "no-such-tag")]
        public void Ctor_String(string tag, string expectedTag)
        {
            HtmlElement element = new HtmlElement(tag);
            Assert.Equal(expectedTag, element.Tag);
            Assert.False(element.IsVoid);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
            Assert.Empty(element.ElementsAndAttributes());
        }

        [Theory]
        [InlineData("html", true, "html")]
        [InlineData("HtMl", false, "html")]
        [InlineData("no-such-tag", false, "no-such-tag")]
        public void Ctor_String_Bool(string tag, bool isVoid, string expectedTag)
        {
            HtmlElement element = new HtmlElement(tag, isVoid);
            Assert.Equal(expectedTag, element.Tag);
            Assert.Equal(isVoid, element.IsVoid);
            Assert.Empty(element.Elements());
            Assert.Empty(element.Attributes());
            Assert.Empty(element.ElementsAndAttributes());
        }

        public static IEnumerable<object[]> Objects_TestData()
        {
            yield return new object[] { new HtmlObject[0] };
            yield return new object[] { new HtmlObject[] { new HtmlAttribute("attribute1") } };
            yield return new object[] { new HtmlObject[] { new HtmlElement("h1") } };
            yield return new object[] { new HtmlObject[] { new HtmlComment("comment") } };
            yield return new object[] { new HtmlObject[] { new HtmlAttribute("attribute1"), new HtmlElement("h1") } };
            yield return new object[] { new HtmlObject[] { new HtmlAttribute("attribute1"), new HtmlComment("comment") } };
            yield return new object[] { new HtmlObject[] { new HtmlComment("comment"), new HtmlElement("h1") } };
            yield return new object[] { new HtmlObject[] { new HtmlComment("attribute1"), new HtmlAttribute("attribute"), new HtmlElement("element") } };
            yield return new object[] { new HtmlObject[] { new HtmlAttribute("attribute1"), new HtmlElement("h1"), new HtmlElement("h1"), new HtmlAttribute("attribute2") } };
        }

        [Theory]
        [MemberData(nameof(Objects_TestData))]
        public void Ctor_String_ParamsHtmlObject(HtmlObject[] content)
        {
            HtmlElement element = new HtmlElement("element", content);
            Assert.Equal("element", element.Tag);
            Assert.False(element.IsVoid);
            Assert.Equal(content.OfType<HtmlElement>().ToArray(), element.Elements().ToArray());
            Assert.Equal(content.OfType<HtmlAttribute>().ToArray(), element.Attributes().ToArray());
            Assert.Equal(content.OfType<HtmlNode>().ToArray(), element.Nodes().ToArray());
            Assert.Equal(element.Elements().Count() + element.Attributes().Count(), element.ElementsAndAttributes().Count());
            Assert.Equal(content.Length, element.NodesAndAttributes().Count());
        }

        [Fact]
        public void Ctor_NullTag_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>("tag", () => new HtmlElement(null));
            Assert.Throws<ArgumentNullException>("tag", () => new HtmlElement(null, isVoid: false));
            Assert.Throws<ArgumentNullException>("tag", () => new HtmlElement(null, new HtmlObject[0]));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" \r \n \t")]
        public void Ctor_EmptyOrWhitespaceTag_ThrowsArgumentException(string tag)
        {
            Assert.Throws<ArgumentException>("tag", () => new HtmlElement(tag));
            Assert.Throws<ArgumentException>("tag", () => new HtmlElement(tag, isVoid: false));
            Assert.Throws<ArgumentException>("tag", () => new HtmlElement(tag, new HtmlObject[0]));
        }

        [Fact]
        public void ObjectType_Get_ReturnsElement()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Equal(HtmlObjectType.Element, element.ObjectType);
        }

        public static IEnumerable<object[]> Equals_TestData()
        {
            // Tag
            yield return new object[] { new HtmlElement("element"), new HtmlElement("element"), true };
            yield return new object[] { new HtmlElement("element"), new HtmlElement("other-element"), false };

            // Void
            yield return new object[] { new HtmlElement("element", isVoid: true), new HtmlElement("element", isVoid: true), true };
            yield return new object[] { new HtmlElement("element", isVoid: true), new HtmlElement("element", isVoid: false), false };

            // InnerText
            yield return new object[] { new HtmlElement("element").WithInnerText("Inner Text"), new HtmlElement("element").WithInnerText("Inner Text"), true };
            yield return new object[] { new HtmlElement("element").WithInnerText("Inner Text"), new HtmlElement("element").WithInnerText("inner text"), false };
            yield return new object[] { new HtmlElement("element").WithInnerText("Inner Text"), new HtmlElement("element").WithInnerText("other-inner-text"), false };

            // Elements
            yield return new object[]
            {
                new HtmlElement("element1", new HtmlElement("element2"), new HtmlAttribute("attribute")),
                new HtmlElement("element1", new HtmlElement("element2"), new HtmlAttribute("attribute")),
                true
            };
            yield return new object[]
            {
                new HtmlElement("element", new HtmlElement("element2"), new HtmlAttribute("attribute")),
                new HtmlElement("element", new HtmlElement("other-element"), new HtmlAttribute("attribute")),
                false
            };
            yield return new object[]
            {
                new HtmlElement("element", new HtmlElement("element2"), new HtmlAttribute("attribute")),
                new HtmlElement("element", new HtmlAttribute("attribute")),
                false
            };

            // Attributes
            yield return new object[]
            {
                new HtmlElement("element1", new HtmlElement("element2"), new HtmlAttribute("attribute")),
                new HtmlElement("element1", new HtmlElement("element2"), new HtmlAttribute("other-attribute")),
                false
            };
            yield return new object[]
            {
                new HtmlElement("element1", new HtmlElement("element2"), new HtmlAttribute("attribute")),
                new HtmlElement("element1", new HtmlElement("element2")),
                false
            };

            // Other
            yield return new object[] { new HtmlElement("element"), new object(), false };
            yield return new object[] { new HtmlElement("element"), null, false };
        }

        [Theory]
        [MemberData(nameof(Equals_TestData))]
        public void Equals(HtmlElement element, object other, bool expected)
        {
            Assert.Equal(element.GetHashCode(), element.GetHashCode());
            if (other is HtmlElement || other == null)
            {
                Assert.Equal(expected, element.Equals((HtmlElement)other));
            }
            Assert.Equal(expected, element.Equals(other));
        }
    }
}
