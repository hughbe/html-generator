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
            Assert.Null(element.InnerText);
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

        [Theory]
        [InlineData("html", "inner-text", "html")]
        [InlineData("HtMl", " \t \r \n ", "html")]
        [InlineData("no-such-tag", "", "no-such-tag")]
        [InlineData("no-such-tag", null, "no-such-tag")]
        public void Ctor_String_String(string tag, string innerText, string expectedTag)
        {
            HtmlElement element = new HtmlElement(tag, innerText);
            Assert.Equal(expectedTag, element.Tag);
            Assert.Equal(innerText, element.InnerText);
            Assert.False(element.IsVoid);
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
            HtmlElement element = new HtmlElement("html", content);
            Assert.Equal("html", element.Tag);
            Assert.Null(element.InnerText);
            Assert.False(element.IsVoid);
            Assert.Equal(content.Where(obj => obj is HtmlElement).Cast<HtmlElement>().ToArray(), element.Elements().ToArray());
            Assert.Equal(content.Where(obj => obj is HtmlAttribute).Cast<HtmlAttribute>().ToArray(), element.Attributes().ToArray());
            Assert.Equal(content.Where(obj => obj is HtmlNode).Cast<HtmlNode>().ToArray(), element.Nodes().ToArray());
            Assert.Equal(element.Elements().Count() + element.Attributes().Count(), element.ElementsAndAttributes().Count());
            Assert.Equal(content.Length, element.NodesAndAttributes().Count());
        }

        [Theory]
        [MemberData(nameof(Objects_TestData))]
        public void Ctor_String_String_ParamsHtmlObject(HtmlObject[] content)
        {
            HtmlElement element = new HtmlElement("html", "inner-text", content);
            Assert.Equal("html", element.Tag);
            Assert.Equal("inner-text", element.InnerText);
            Assert.False(element.IsVoid);
            Assert.Equal(content.Where(obj => obj is HtmlElement).Cast<HtmlElement>().ToArray(), element.Elements().ToArray());
            Assert.Equal(content.Where(obj => obj is HtmlAttribute).Cast<HtmlAttribute>().ToArray(), element.Attributes().ToArray());
            Assert.Equal(content.Where(obj => obj is HtmlNode).Cast<HtmlNode>().ToArray(), element.Nodes().ToArray());
            Assert.Equal(element.Elements().Count() + element.Attributes().Count(), element.ElementsAndAttributes().Count());
            Assert.Equal(content.Length, element.NodesAndAttributes().Count());
        }

        [Fact]
        public void ObjectType_Get_ReturnsElement()
        {
            HtmlElement attribute = new HtmlElement("div");
            Assert.Equal(HtmlObjectType.Element, attribute.ObjectType);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(9)]
        public void MinimumIndentLength_Set_Get_ReturnsExpected(int value)
        {
            HtmlElement element = new HtmlElement("div");
            Assert.Equal(1, element.MinimumIndentDepth);

            element.MinimumIndentDepth = value;
            Assert.Equal(value, element.MinimumIndentDepth);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(10)]
        public void MinimumIndentLength_Set_InvalidValue_ThrowsArgumentOutOfRangeException(int value)
        {
            HtmlElement element = new HtmlElement("div");
            Assert.Throws<ArgumentOutOfRangeException>("value", () => element.MinimumIndentDepth = value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(8)]
        [InlineData(10)]
        public void MaximumIndentLength_Set_Get_ReturnsExpected(int value)
        {
            HtmlElement element = new HtmlElement("div");
            Assert.Equal(9, element.MaximumIndentDepth);

            element.MaximumIndentDepth = value;
            Assert.Equal(value, element.MaximumIndentDepth);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void MaximumIndentLength_Set_InvalidValue_ThrowsArgumentOutOfRangeException(int value)
        {
            HtmlElement element = new HtmlElement("div");
            Assert.Throws<ArgumentOutOfRangeException>("value", () => element.MaximumIndentDepth = value);
        }

        public static IEnumerable<object[]> Equals_TestData()
        {
            // Tag
            yield return new object[] { new HtmlElement("tag"), new HtmlElement("tag"), true };
            yield return new object[] { new HtmlElement("tag"), new HtmlElement("other-tag"), false };

            // Void
            yield return new object[] { new HtmlElement("tag", isVoid: true), new HtmlElement("tag", isVoid: true), true };
            yield return new object[] { new HtmlElement("tag", isVoid: true), new HtmlElement("tag", isVoid: false), false };

            // InnerText
            yield return new object[] { new HtmlElement("tag").WithInnerText("Inner Text"), new HtmlElement("tag").WithInnerText("Inner Text"), true };
            yield return new object[] { new HtmlElement("tag").WithInnerText("Inner Text"), new HtmlElement("tag").WithInnerText("inner text"), false };
            yield return new object[] { new HtmlElement("tag").WithInnerText("Inner Text"), new HtmlElement("tag").WithInnerText("other-inner-text"), false };

            // Elements
            yield return new object[]
            {
                new HtmlElement("tag", new HtmlElement("element"), new HtmlAttribute("attribute")),
                new HtmlElement("tag", new HtmlElement("element"), new HtmlAttribute("attribute")),
                true
            };
            yield return new object[]
            {
                new HtmlElement("tag", new HtmlElement("element"), new HtmlAttribute("attribute")),
                new HtmlElement("tag", new HtmlElement("other-element"), new HtmlAttribute("attribute")),
                false
            };
            yield return new object[]
            {
                new HtmlElement("tag", new HtmlElement("element"), new HtmlAttribute("attribute")),
                new HtmlElement("tag", new HtmlAttribute("attribute")),
                false
            };

            // Attributes
            yield return new object[]
            {
                new HtmlElement("tag", new HtmlElement("element"), new HtmlAttribute("attribute")),
                new HtmlElement("tag", new HtmlElement("element"), new HtmlAttribute("other-attribute")),
                false
            };
            yield return new object[]
            {
                new HtmlElement("tag", new HtmlElement("element"), new HtmlAttribute("attribute")),
                new HtmlElement("tag", new HtmlElement("element")),
                false
            };

            // Other
            yield return new object[] { new HtmlElement("tag"), new object(), false };
            yield return new object[] { new HtmlElement("tag"), null, false };
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
