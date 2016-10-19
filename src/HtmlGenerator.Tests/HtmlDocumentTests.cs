using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlDocumentTests
    {
        [Fact]
        public void Ctor()
        {
            HtmlDocument document = new HtmlDocument();
            Assert.Equal("html", document.Tag);
            Assert.Null(document.InnerText);
            Assert.False(document.IsVoid);
            Assert.Equal(2, document.Elements().Count());
            Assert.Empty(document.Attributes());
            Assert.Equal(2, document.ElementsAndAttributes().Count());

            Assert.Equal("<head></head>", document.Head.ToString());
            Assert.Equal("<body></body>", document.Body.ToString());
        }

        [Fact]
        public void Doctype_Get_ReturnsExpected()
        {
            HtmlDocument document = new HtmlDocument();
            Assert.Equal(new HtmlDoctype(HtmlDoctypeType.Html5), document.Doctype);
        }

        public static IEnumerable<object[]> Doctype_TestData()
        {
            yield return new object[] { new HtmlDoctype(HtmlDoctypeType.Html5) };
            yield return new object[] { new HtmlDoctype("doctype") };
            yield return new object[] { null };
        }

        [Theory]
        [MemberData(nameof(Doctype_TestData))]
        public void Doctype_Set_Get_ReturnsExpected(HtmlDoctype value)
        {
            HtmlDocument document = new HtmlDocument();
            document.Doctype = value;
            Assert.Equal(value, document.Doctype);
        }

        [Theory]
        [MemberData(nameof(Doctype_TestData))]
        public void Serialize_NullDoctype_NotIncluded(HtmlDoctype doctype)
        {
            HtmlDocument document = new HtmlDocument();
            document.Doctype = doctype;

            string expectedDocType = doctype == null ? string.Empty : doctype + Environment.NewLine;
            Helpers.SerializeIgnoringFormatting(document, string.Format(@"{0}<html>
<head></head>
<body></body>
</html>", expectedDocType));
        }

        [Fact]
        public void Serialize_EmptyHtmlDocument()
        {
            HtmlDocument document = new HtmlDocument();
            Helpers.SerializeIgnoringFormatting(document, @"<!DOCTYPE html>
<html>
<head></head>
<body></body>
</html>");
        }

        [Fact]
        public void Serialize_Complex()
        {
            HtmlDocument document = new HtmlDocument();
            document.Head.Add(Tag.Title.WithInnerText("Title"));
            document.Body.Add(Tag.Header1("Header1").WithClass("aClass"));
            document.Body.Add(Tag.Br);
            document.Body.Add(Tag.Paragraph("Paragraph").WithAttribute(Attribute.AllowFullScreen));

            Helpers.SerializeIgnoringFormatting(document, @"<!DOCTYPE html>
<html>
<head>
  <title>Title</title>
</head>
<body>
  <h1 class=""aClass"">Header1</h1>
  <br />
  <p allowfullscreen>Paragraph</p>
</body>
</html>");
        }
    }
}
