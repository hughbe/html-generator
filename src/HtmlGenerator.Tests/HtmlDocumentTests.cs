using System;
using System.Collections.Generic;
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
            Assert.False(document.IsVoid);
            Assert.True(document.IsEmpty);

            Assert.Null(document.Head);
            Assert.Null(document.Body);
        }

        [Fact]
        public void ObjectType_Get_ReturnsDocument()
        {
            HtmlDocument document = new HtmlDocument();
            Assert.Equal(HtmlObjectType.Document, document.ObjectType);
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

        [Fact]
        public void Head_SetExisting_NonNull_RemovesElement()
        {
            HtmlElement value = Tag.Head.WithClass("class");
            HtmlDocument document = new HtmlDocument() { Head = Tag.Head };
            document.Head = value;
            Assert.Equal(new HtmlElement[] { value }, document.Elements());
            Assert.Equal(value, document.Head);
        }

        [Fact]
        public void Head_SetExisting_Null_RemovesElement()
        {
            HtmlDocument document = new HtmlDocument() { Head = Tag.Head };
            document.Head = null;
            Assert.True(document.IsEmpty);
            Assert.Null(document.Head);
        }

        [Fact]
        public void Head_SetNonExisting_Null_RemovesElement()
        {
            HtmlDocument document = new HtmlDocument() { Head = null };
            document.Head = null;
            Assert.True(document.IsEmpty);
            Assert.Null(document.Head);
        }
        
        [Fact]
        public void AddHead_DocumentHasBody_ThrowsInvalidOperationException()
        {
            HtmlDocument document = new HtmlDocument() { Head = Tag.Head };
            Assert.Throws<InvalidOperationException>(() => document.AddHead());
        }

        [Fact]
        public void Body_SetExisting_NonNull_RemovesElement()
        {
            HtmlElement value = Tag.Body.WithClass("class");
            HtmlDocument document = new HtmlDocument() { Body = Tag.Body };
            document.Body = value;
            Assert.Equal(new HtmlElement[] { value }, document.Elements());
            Assert.Equal(value, document.Body);
        }

        [Fact]
        public void Body_SetExisting_Null_RemovesElement()
        {
            HtmlDocument document = new HtmlDocument() { Body = Tag.Body };
            document.Body = null;
            Assert.True(document.IsEmpty);
            Assert.Null(document.Body);
        }

        [Fact]
        public void Body_SetNonExisting_Null_RemovesElement()
        {
            HtmlDocument document = new HtmlDocument() { Body = null };
            document.Body = null;
            Assert.True(document.IsEmpty);
            Assert.Null(document.Body);
        }

        [Fact]
        public void AddBody_DocumentHasBody_ThrowsInvalidOperationException()
        {
            HtmlDocument document = new HtmlDocument() { Body = Tag.Body };
            Assert.Throws<InvalidOperationException>(() => document.AddBody());
        }

        public static IEnumerable<object[]> Equals_TestData()
        {
            yield return new object[] { new HtmlDocument(), new HtmlDocument(), true };
            yield return new object[] { new HtmlDocument(), new HtmlDocument().WithClass("class"), false };

            yield return new object[] { new HtmlDocument() { Doctype = null }, new HtmlDocument() { Doctype = null }, true };
            yield return new object[] { new HtmlDocument() { Doctype = null }, new HtmlDocument() { Doctype = new HtmlDoctype(HtmlDoctypeType.Html5) }, false };
            yield return new object[] { new HtmlDocument() { Doctype = new HtmlDoctype(HtmlDoctypeType.Html5) }, new HtmlDocument() { Doctype = null }, false };
            yield return new object[] { new HtmlDocument() { Doctype = new HtmlDoctype(HtmlDoctypeType.Html5) }, new HtmlDocument() { Doctype = new HtmlDoctype(HtmlDoctypeType.Html401Frameset) }, false };
        }

        [Theory]
        [MemberData(nameof(Equals_TestData))]
        public void Equals(HtmlDocument document, object other, bool expected)
        {
            if (other is HtmlDocument || other == null)
            {
                if (expected)
                {
                    Assert.Equal(expected, document.GetHashCode().Equals(other?.GetHashCode()));
                }
                Assert.Equal(expected, document.Equals((HtmlDocument)other));
            }
            Assert.Equal(expected, document.Equals(other));
        }

        [Theory]
        [MemberData(nameof(Doctype_TestData))]
        public void Serialize_NullDoctype_NotIncluded(HtmlDoctype doctype)
        {
            HtmlDocument document = new HtmlDocument();
            document.Doctype = doctype;

            string expectedDocType = doctype == null ? string.Empty : doctype + Environment.NewLine;
            Helpers.SerializeIgnoringFormatting(document, string.Format(@"{0}<html></html>", expectedDocType));
        }

        [Fact]
        public void Serialize_EmptyHtmlDocument()
        {
            HtmlDocument document = new HtmlDocument();
            Helpers.SerializeIgnoringFormatting(document, @"<!DOCTYPE html>
<html></html>");
        }

        [Fact]
        public void Serialize_Complex()
        {
            HtmlDocument document = new HtmlDocument().AddHead().AddBody();
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
