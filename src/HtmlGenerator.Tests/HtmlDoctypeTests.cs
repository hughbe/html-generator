using System;
using System.Collections.Generic;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlDoctypeTests
    {
        [Theory]
        [InlineData(HtmlDoctypeType.Html5, "DOCTYPE html")]
        [InlineData(HtmlDoctypeType.Html401Strict, "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\"")]
        [InlineData(HtmlDoctypeType.Html401Transitional, "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\"")]
        [InlineData(HtmlDoctypeType.Html401Frameset, "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\"")]
        [InlineData(HtmlDoctypeType.XHtml10Strict, "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"")]
        [InlineData(HtmlDoctypeType.XHtml10Transitional, "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"")]
        [InlineData(HtmlDoctypeType.XHtml10Frameset, "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\"")]
        [InlineData(HtmlDoctypeType.XHtml11, "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"")]
        public void Ctor_HtmlDoctypeType(HtmlDoctypeType doctype, string expectedDoctype)
        {
            HtmlDoctype htmlDoctype = new HtmlDoctype(doctype);
            Assert.Equal(expectedDoctype, htmlDoctype.Doctype);
            Assert.Equal(doctype, htmlDoctype.DoctypeType);
            Assert.True(htmlDoctype.IsVoid);
            Assert.True(htmlDoctype.IsEmpty);
        }

        [Theory]
        [InlineData(HtmlDoctypeType.Html5 - 1)]
        [InlineData(HtmlDoctypeType.Custom)]
        [InlineData(HtmlDoctypeType.Custom + 1)]
        public void Ctor_NotSupportedHtmlDoctypeType_ThrowsArgumentException(HtmlDoctypeType doctype)
        {
            Assert.Throws<ArgumentException>("doctype", () => new HtmlDoctype(doctype));
        }

        [Theory]
        [InlineData("doctype", HtmlDoctypeType.Custom)]
        [InlineData("DOCTYPE", HtmlDoctypeType.Custom)]
        [InlineData("DOCTYPE html", HtmlDoctypeType.Html5)]
        [InlineData("DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\"", HtmlDoctypeType.Html401Strict)]
        [InlineData("DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\"", HtmlDoctypeType.Html401Transitional)]
        [InlineData("DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\"", HtmlDoctypeType.Html401Frameset)]
        [InlineData("DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"", HtmlDoctypeType.XHtml10Strict)]
        [InlineData("DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"", HtmlDoctypeType.XHtml10Transitional)]
        [InlineData("DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\"", HtmlDoctypeType.XHtml10Frameset)]
        [InlineData("DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"", HtmlDoctypeType.XHtml11)]
        public void Ctor_String(string doctype, HtmlDoctypeType expectedDoctypeType)
        {
            HtmlDoctype htmlDoctype = new HtmlDoctype(doctype);
            Assert.Equal(doctype, htmlDoctype.Doctype);
            Assert.Equal(expectedDoctypeType, htmlDoctype.DoctypeType);
            Assert.True(htmlDoctype.IsVoid);
            Assert.True(htmlDoctype.IsEmpty);
        }

        [Fact]
        public void Ctor_NullDoctype_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>("doctype", () => new HtmlDoctype(null));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" \r \t \n ")]
        public void Ctor_EmptyOrWhitespaceDoctype_ThrowsArgumentException(string doctype)
        {
            Assert.Throws<ArgumentException>("doctype", () => new HtmlDoctype(doctype));
        }

        [Fact]
        public void ObjectType_Get_ReturnsDoctye()
        {
            HtmlDoctype doctype = new HtmlDoctype("doctype");
            Assert.Equal(HtmlObjectType.Doctype, doctype.ObjectType);
        }

        public static IEnumerable<object[]> Equals_TestData()
        {
            yield return new object[] { new HtmlDoctype("doctype"), new HtmlDoctype("doctype"), true };
            yield return new object[] { new HtmlDoctype("doctype"), new HtmlDoctype("other-doctype"), false };
            yield return new object[] { new HtmlDoctype("doctype"), new HtmlDoctype("DOCTYPE"), false };

            yield return new object[] { new HtmlDoctype("doctype"), new object(), false };
            yield return new object[] { new HtmlDoctype("doctype"), null, false };
        }

        [Theory]
        [MemberData(nameof(Equals_TestData))]
        public void Equals_ReturnsExpected(HtmlDoctype doctype, object other, bool expected)
        {
            if (other is HtmlDoctype || other == null)
            {
                Assert.Equal(expected, doctype.GetHashCode().Equals(other?.GetHashCode()));
                Assert.Equal(expected, doctype.Equals((HtmlDoctype)other));
            }
            Assert.Equal(expected, doctype.Equals(other));
        }

        public static IEnumerable<object[]> ToString_TestData()
        {
            yield return new object[] { new HtmlDoctype("doctype"), "<!doctype>" };
            yield return new object[] { new HtmlDoctype("DOCTYPE"), "<!DOCTYPE>" };
        }

        [Theory]
        [MemberData(nameof(ToString_TestData))]
        public void ToString_ReturnsExpected(HtmlDoctype doctype, string expected)
        {
            Assert.Equal(expected, doctype.ToString());
            Assert.Equal(expected, doctype.Serialize());
            Assert.Equal(expected, doctype.Serialize(HtmlSerializeOptions.None));
            Assert.Equal(expected, doctype.Serialize(HtmlSerializeOptions.NoFormatting));
        }
    }
}
