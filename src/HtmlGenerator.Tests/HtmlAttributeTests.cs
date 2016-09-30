using System;
using System.Collections.Generic;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlAttributeTests
    {
        [Theory]
        [InlineData("name")]
        [InlineData("NaMe")]
        public void Ctor_String(string name)
        {
            HtmlAttribute attribute = new HtmlAttribute(name);
            Assert.Equal(name, attribute.Name);
            Assert.Null(attribute.Value);
            Assert.True(attribute.IsVoid);
        }

        [Theory]
        [InlineData("name", "")]
        [InlineData("name", " \r \t \n")]
        [InlineData("name", "value")]
        [InlineData("NaMe", "VaLuE")]
        public void Ctor_String_String(string name, string value)
        {
            HtmlAttribute attribute = new HtmlAttribute(name, value);
            Assert.Equal(name, attribute.Name);
            Assert.Equal(value, attribute.Value);
            Assert.False(attribute.IsVoid);
        }

        [Fact]
        public void Ctor_NullName_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>("name", () => new HtmlAttribute(null));
            Assert.Throws<ArgumentNullException>("name", () => new HtmlAttribute(null, "value"));
        }

        [Theory]
        [InlineData("")]
        [InlineData("\t \r \n")]
        public void Ctor_WhitespaceName_ThrowsArgumentException(string name)
        {
            Assert.Throws<ArgumentException>("name", () => new HtmlAttribute(name));
            Assert.Throws<ArgumentException>("name", () => new HtmlAttribute(name, "value"));
        }

        [Fact]
        public void Ctor_NullValue_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>("value", () => new HtmlAttribute("name", null));
        }

        public static IEnumerable<object[]> ToString_TestData()
        {
            yield return new object[] { new HtmlAttribute("name"), "name" };
            yield return new object[] { new HtmlAttribute("name", "value"), "name=\"value\"" };
        }

        [Theory]
        [MemberData(nameof(ToString_TestData))]
        public void ToString_ReturnsExpected(HtmlAttribute attribute, string expected)
        {
            Assert.Equal(expected, attribute.ToString());
            Assert.Equal(expected, attribute.Serialize());
            Assert.Equal(expected, attribute.Serialize(HtmlSerializeOptions.None));
            Assert.Equal(expected, attribute.Serialize(HtmlSerializeOptions.NoFormatting));
        }
    }
}
