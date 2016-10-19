using System;
using System.Collections.Generic;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlCommentTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" \t \r \n")]
        [InlineData("comment")]
        [InlineData("CoMmEnT")]
        public void Ctor_String(string comment)
        {
            HtmlComment htmlComment = new HtmlComment(comment);
            Assert.Equal(comment, htmlComment.Comment);
        }

        [Fact]
        public void Ctor_NullComment_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>("comment", () => new HtmlComment(null));
        }

        [Fact]
        public void ObjectType_Get_ReturnsComment()
        {
            HtmlComment comment = new HtmlComment("comment");
            Assert.Equal(HtmlObjectType.Comment, comment.ObjectType);
        }

        public static IEnumerable<object[]> Equals_TestData()
        {
            yield return new object[] { new HtmlComment("comment"), new HtmlComment("comment"), true };
            yield return new object[] { new HtmlComment("comment"), new HtmlComment("other-comment"), false };
            yield return new object[] { new HtmlComment("comment"), new HtmlComment("COMMENT"), false };

            yield return new object[] { new HtmlComment("comment"), new object(), false };
            yield return new object[] { new HtmlComment("comment"), null, false };
        }

        [Theory]
        [MemberData(nameof(Equals_TestData))]
        public void Equals_ReturnsExpected(HtmlComment comment, object other, bool expected)
        {
            if (other is HtmlComment || other == null)
            {
                Assert.Equal(expected, comment.GetHashCode().Equals(other?.GetHashCode()));
                Assert.Equal(expected, comment.Equals((HtmlComment)other));
            }
            Assert.Equal(expected, comment.Equals(other));
        }

        public static IEnumerable<object[]> ToString_TestData()
        {
            yield return new object[] { new HtmlComment(""), "<!---->" };
            yield return new object[] { new HtmlComment("comment"), "<!--comment-->" };
            yield return new object[] { new HtmlComment("COMMENT"), "<!--COMMENT-->" };
        }

        [Theory]
        [MemberData(nameof(ToString_TestData))]
        public void ToString_ReturnsExpected(HtmlComment comment, string expected)
        {
            Assert.Equal(expected, comment.ToString());
            Assert.Equal(expected, comment.Serialize());
            Assert.Equal(expected, comment.Serialize(HtmlSerializeOptions.None));
            Assert.Equal(expected, comment.Serialize(HtmlSerializeOptions.NoFormatting));
        }
    }
}
