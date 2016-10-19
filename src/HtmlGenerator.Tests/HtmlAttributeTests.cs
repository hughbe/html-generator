using System;
using System.Collections.Generic;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlAttributeTests
    {
        [Theory]
        [InlineData("name", "name")]
        [InlineData("NaMe", "name")]
        public void Ctor_String(string name, string expectedName)
        {
            HtmlAttribute attribute = new HtmlAttribute(name);
            Assert.Equal(expectedName, attribute.Name);
            Assert.Null(attribute.Value);
            Assert.True(attribute.IsVoid);
        }

        [Theory]
        [InlineData("name", "", "name")]
        [InlineData("name", " \r \t \n", "name")]
        [InlineData("name", "value", "name")]
        [InlineData("NaMe", "VaLuE", "name")]
        public void Ctor_String_String(string name, string value, string expectedName)
        {
            HtmlAttribute attribute = new HtmlAttribute(name, value);
            Assert.Equal(expectedName, attribute.Name);
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

        [Fact]
        public void ObjectType_Get_ReturnsAttribute()
        {
            HtmlAttribute attribute = new HtmlAttribute("Attribute");
            Assert.Equal(HtmlObjectType.Attribute, attribute.ObjectType);
        }

        [Fact]
        public void RemoveFromParent_FirstChild()
        {
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            HtmlAttribute attribute3 = new HtmlAttribute("attribute3");
            HtmlElement element = new HtmlElement("element", attribute1, attribute2, attribute3);

            attribute1.RemoveFromParent();
            Assert.Null(attribute1.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute2, attribute3 }, element.Attributes());
        }

        [Fact]
        public void RemoveFromParent_LastChild()
        {
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            HtmlAttribute attribute3 = new HtmlAttribute("attribute3");
            HtmlElement element = new HtmlElement("element", attribute1, attribute2, attribute3);

            attribute3.RemoveFromParent();
            Assert.Null(attribute3.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute1, attribute2 }, element.Attributes());
        }

        [Fact]
        public void RemoveFromParent_MiddleChild()
        {
            HtmlAttribute attribute1 = new HtmlAttribute("attribute1");
            HtmlAttribute attribute2 = new HtmlAttribute("attribute2");
            HtmlAttribute attribute3 = new HtmlAttribute("attribute3");
            HtmlElement element = new HtmlElement("element", attribute1, attribute2, attribute3);

            attribute2.RemoveFromParent();
            Assert.Null(attribute2.Parent);
            Assert.Equal(new HtmlAttribute[] { attribute1, attribute3 }, element.Attributes());
        }

        [Fact]
        public void RemoveFromParent_NoParent_DoesNothing()
        {
            HtmlAttribute attribute = new HtmlAttribute("attribute");
            attribute.RemoveFromParent();

            Assert.Null(attribute.Parent);
        }

        [Theory]
        [InlineData("Value")]
        [InlineData(" \r \n \t")]
        [InlineData("")]
        public void SetValue(string value)
        {
            HtmlAttribute attribute = new HtmlAttribute("attribute");
            attribute.SetValue(value);
            Assert.Equal(value, attribute.Value);
        }

        [Fact]
        public void SetValue_NullValue_ThrowsArgumentNullException()
        {
            HtmlAttribute attribute = new HtmlAttribute("a  ttribute");
            Assert.Throws<ArgumentNullException>("value", () => attribute.SetValue(null));
        }

        public static IEnumerable<object[]> Equals_TestData()
        {
            yield return new object[] { new HtmlAttribute("name"), new HtmlAttribute("name"), true };
            yield return new object[] { new HtmlAttribute("name"), new HtmlAttribute("other-name"), false };
            yield return new object[] { new HtmlAttribute("name"), new HtmlAttribute("name", "value"), false };

            yield return new object[] { new HtmlAttribute("name", "value"), new HtmlAttribute("name"), false };
            yield return new object[] { new HtmlAttribute("name", "value"), new HtmlAttribute("name", "value"), true };
            yield return new object[] { new HtmlAttribute("name", "value"), new HtmlAttribute("name", "Value"), false };
            yield return new object[] { new HtmlAttribute("name", "value"), new HtmlAttribute("name", "other-value"), false };

            yield return new object[] { new HtmlAttribute("name"), new object(), false };
            yield return new object[] { new HtmlAttribute("name"), null, false };
        }

        [Theory]
        [MemberData(nameof(Equals_TestData))]
        public void Equals_ReturnsExpected(HtmlAttribute attribute, object other, bool expected)
        {
            if (other is HtmlAttribute || other == null)
            {
                Assert.Equal(expected, attribute.GetHashCode().Equals(other?.GetHashCode()));
                Assert.Equal(expected, attribute.Equals((HtmlAttribute)other));
            }
            Assert.Equal(expected, attribute.Equals(other));
        }

        public static IEnumerable<object[]> ToString_TestData()
        {
            yield return new object[] { new HtmlAttribute("name"), "name" };
            yield return new object[] { new HtmlAttribute("name", "value"), "name=\"value\"" };
            yield return new object[] { new HtmlAttribute("name", "Value"), "name=\"Value\"" };
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
