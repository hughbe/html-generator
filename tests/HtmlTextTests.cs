using System;
using System.Collections.Generic;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlTextTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" \t \r \n")]
        [InlineData("text")]
        [InlineData("TeXt")]
        public void Ctor_String(string text)
        {
            HtmlText htmlText = new HtmlText(text);
            Assert.Equal(text, htmlText.Text);
        }

        [Fact]
        public void Ctor_NullText_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>("text", () => new HtmlText(null));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" \t \r \n")]
        [InlineData("text")]
        [InlineData("TeXt")]
        public void ImplicitOperator_String(string text)
        {
            HtmlText htmlText = text;
            Assert.Equal(text, htmlText.Text);
        }

        [Fact]
        public void ImplicitOperator_NullString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>("text", () => { HtmlText text = (string)null; });
        }

        [Fact]
        public void ObjectType_Get_ReturnsText()
        {
            HtmlText text = new HtmlText("text");
            Assert.Equal(HtmlObjectType.Text, text.ObjectType);
        }

        public static IEnumerable<object[]> Equals_TestData()
        {
            yield return new object[] { new HtmlText("text"), new HtmlText("text"), true };
            yield return new object[] { new HtmlText("text"), new HtmlText("other-text"), false };
            yield return new object[] { new HtmlText("text"), new HtmlText("TEXT"), false };

            yield return new object[] { new HtmlText("text"), new object(), false };
            yield return new object[] { new HtmlText("text"), null, false };
        }

        [Theory]
        [MemberData(nameof(Equals_TestData))]
        public void Equals_ReturnsExpected(HtmlText text, object other, bool expected)
        {
            if (other is HtmlText || other == null)
            {
                Assert.Equal(expected, text.GetHashCode().Equals(other?.GetHashCode()));
                Assert.Equal(expected, text.Equals((HtmlText)other));
            }
            Assert.Equal(expected, text.Equals(other));
        }

        public static IEnumerable<object[]> ToString_TestData()
        {
            yield return new object[] { new HtmlText(""), "" };
            yield return new object[] { new HtmlText(" \r \t \n "), " \r \t \n " };
            yield return new object[] { new HtmlText("text"), "text" };
            yield return new object[] { new HtmlText("TEXT"), "TEXT" };
        }

        [Theory]
        [MemberData(nameof(ToString_TestData))]
        public void ToString_ReturnsExpected(HtmlText text, string expected)
        {
            Assert.Equal(expected, text.ToString());
            Assert.Equal(expected, text.Serialize());
            Assert.Equal(expected, text.Serialize(HtmlSerializeOptions.None));
            Assert.Equal(expected, text.Serialize(HtmlSerializeOptions.NoFormatting));
        }
    }
}
