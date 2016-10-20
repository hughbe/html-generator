using System.Collections.Generic;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlElementParseTests
    {
        [Fact]
        public void VoidElement_NoWhitespace()
        {
            Assert.Equal(new HtmlElement("br", isVoid: true), HtmlElement.Parse("<br/>"));
        }

        [Fact]
        public void VoidElement_Whitespace()
        {
            Assert.Equal(new HtmlElement("br", isVoid: true), HtmlElement.Parse(" < br / > "));
        }

        [Fact]
        public void NonVoidElement_NoInnerText_NoChildren_NoWhitespace_Lowercase()
        {
            Assert.Equal(new HtmlElement("div"), HtmlElement.Parse("<div></div>"));
        }

        [Fact]
        public void NonVoidElement_NoInnerText_NoChildren_NoWhitespace_Uppercase()
        {
            Assert.Equal(new HtmlElement("div"), HtmlElement.Parse("<DIV></DIV>"));
        }

        [Fact]
        public void NonVoidElement_NoInnerText_NoChildren_NoWhitespace_MixedCase()
        {
            Assert.Equal(new HtmlElement("div"), HtmlElement.Parse("<DiV></dIv>"));
        }

        [Fact]
        public void NonVoidElement_NoInnerText_NoChildren_Whitespace()
        {
            Assert.Equal(new HtmlElement("div"), HtmlElement.Parse(" < div >< / div > "));
        }

        [Fact]
        public void NonVoidElement_InnerText_NoChildren()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithInnerText("InnerText");

            Assert.Equal(expected, HtmlElement.Parse("<div>InnerText</div>"));
        }

        [Fact]
        public void NonVoidElement_NoInnerText_OneNonVoidChild()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithChild(new HtmlElement("p"));

            Assert.Equal(expected, HtmlElement.Parse("<div><p></p></div>"));
        }

        [Fact]
        public void NonVoidElement_InnerTextStart_OneNonVoidChild()
        {
            HtmlElement expected = new HtmlElement("div").WithChildren(new HtmlNode[]
            {
                new HtmlText("InnerText"),
                new HtmlElement("p")
            });

            Assert.Equal(expected, HtmlElement.Parse("<div>InnerText<p></p></div>"));
        }

        [Fact]
        public void NonVoidElement_InnerTextEnd_OneNonVoidChild()
        {
            HtmlElement expected = new HtmlElement("div").WithChildren(new HtmlNode[]
            {
                new HtmlElement("p"),
                new HtmlText("InnerText")
            });

            Assert.Equal(expected, HtmlElement.Parse("<div><p></p>InnerText</div>"));
        }

        [Fact]
        public void NonVoidElement_InnerTextStartAndEnd_OneNonVoidChild()
        {
            HtmlElement expected = new HtmlElement("div").WithChildren(new HtmlNode[]
            {
                new HtmlText("Inner"),
                new HtmlElement("p"),
                new HtmlText("Text")
            });

            Assert.Equal(expected, HtmlElement.Parse("<div>Inner<p></p>Text</div>"));
        }

        [Fact]
        public void NonVoidElement_NoInnerText_OneVoidChild()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithChild(new HtmlElement("br", isVoid: true));

            Assert.Equal(expected, HtmlElement.Parse("<div><br/></div>"));
        }

        [Fact]
        public void NonVoidElement_NoInnerText_MultipleChildren()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithChild(new HtmlElement("p"))
                .WithChild(new HtmlElement("h1"));

            Assert.Equal(expected, HtmlElement.Parse("<div><p></p><h1></h1></div>"));
        }

        [Fact]
        public void NonVoidElement_NoInnerText_MultipleNestedChildren()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithChildren(new HtmlElement[]
                {
                    new HtmlElement("div").WithChildren(new HtmlElement[]
                    {
                        new HtmlElement("p").WithInnerText("Text"),
                        new HtmlElement("h1")
                    }),
                    new HtmlElement("br", isVoid: true),
                    new HtmlElement("section").WithChildren(new HtmlElement[]
                    {
                        new HtmlElement("div").WithChildren(new HtmlElement[]
                        {
                            new HtmlElement("h2").WithInnerText("InnerText"),
                            new HtmlElement("hr", isVoid: true),
                            new HtmlElement("p").WithInnerText("Content")
                        }),
                        new HtmlElement("h3")
                    })
                });

            Assert.Equal(expected, HtmlElement.Parse(@"
<div>
	<div>
		<p>Text</p>
		<h1></h1>
	</div>
	<br/>
	<section>
		<div>
			<h2>InnerText</h2>
			<hr/>
			<p>Content</p>
		</div>
		<h3></h3>
	</section>
</div>"));
        }

        [Fact]
        public void VoidElement_OneVoidAttribute_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("allowfullscreen"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br allowfullscreen/>"));
        }

        [Fact]
        public void VoidElement_OneVoidAttribute_Whitespace()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("allowfullscreen"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br   allowfullscreen  />"));
        }

        [Fact]
        public void VoidElement_OneNonEmptyNonVoidAttribute_NoWhitespace_Lowercase()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br class=""abc""/>"));
        }

        [Fact]
        public void VoidElement_OneNonEmptyNonVoidAttribute_NoWhitespace_Uppercase()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("class", "ABC"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br CLASS=""ABC""/>"));
        }

        [Fact]
        public void VoidElement_OneNonEmptyNonVoidAttribute_NoWhitespace_MixedCase()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("class", "AbC"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br ClAsS=""AbC""/>"));
        }

        [Fact]
        public void VoidElement_OneNonEmptyNonVoidAttribute_Whitespace()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br   class = ""abc""  />"));
        }

        [Fact]
        public void VoidElement_OneNonEmptySingleDelimitedNonVoidAttribute_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br class='abc'/>"));
        }

        [Fact]
        public void VoidElement_OneNonEmptySingleDelimitedNonVoidAttribute_Whitespace()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br class  =  'abc'  />"));
        }

        [Fact]
        public void VoidElement_MultipleNonEmptySingleDelimitedNonVoidAttribute_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true)
                .WithAttributes(new HtmlAttribute[]
                {
                    new HtmlAttribute("class", "abc"),
                    new HtmlAttribute("id", ""),
                    new HtmlAttribute("style", "def")
                });
            Assert.Equal(expected, HtmlElement.Parse(@"<br class='abc' id='' style='def'/>"));
        }

        [Fact]
        public void VoidElement_OneNonEmptyNonDelimitedNonVoidAttribute_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br class=abc/>"));
        }

        [Fact]
        public void VoidElement_OneNonEmptyNonDelimitedNonVoidAttribute_Whitespace()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true).WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<br class  =  abc  />"));
        }

        [Fact]
        public void VoidElement_MultipleNonEmptyNonDelimitedNonVoidAttribute_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("br", isVoid: true)
                .WithAttributes(new HtmlAttribute[]
                {
                    new HtmlAttribute("class", "abc"),
                    new HtmlAttribute("style", "def")
                });
            Assert.Equal(expected, HtmlElement.Parse(@"<br class=abc style=def/>"));
        }

        [Fact]
        public void NonVoidElement_OneVoidAttribute_NoChildren_NoInnerText_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("div").WithAttribute(new HtmlAttribute("allowfullscreen"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div allowfullscreen></div>"));
        }

        [Fact]
        public void NonVoidElement_OneVoidAttribute_NoChildren_NoInnerText_Whitespace()
        {
            HtmlElement expected = new HtmlElement("div").WithAttribute(new HtmlAttribute("allowfullscreen"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div   allowfullscreen  ></div>"));
        }

        [Fact]
        public void NonVoidElement_OneNonEmptyNonVoidAttribute_NoChildren_NoInnerText_NoWhitespace_Lowercase()
        {
            HtmlElement expected = new HtmlElement("div").WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div class=""abc""></div>"));
        }

        [Fact]
        public void NonVoidElement_OneNonEmptyNonVoidAttribute_NoChildren_NoInnerText_NoWhitespace_Uppercase()
        {
            HtmlElement expected = new HtmlElement("div").WithAttribute(new HtmlAttribute("class", "ABC"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div CLASS=""ABC""></div>"));
        }

        [Fact]
        public void NonVoidElement_OneNonEmptyNonVoidAttribute_NoChildren_NoInnerText_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("div").WithAttribute(new HtmlAttribute("class", "aBc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div ClAsS=""aBc""></div>"));
        }

        [Fact]
        public void NonVoidElement_OneNonEmptyNonVoidAttribute_NoChildren_NoInnerText_Whitespace()
        {
            HtmlElement expected = new HtmlElement("div").WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div   class = ""abc""  ></div>"));
        }

        [Fact]
        public void NonVoidElement_OneNonEmptyNonVoidSingleDelimetedAttribute_NoChildren_NoInnerText_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("div").WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div class='abc'></div>"));
        }

        [Fact]
        public void NonVoidElement_MultipleNonEmptyNonVoidSingleDelimetedAttribute_NoChildren_NoInnerText_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithAttributes(new HtmlAttribute[]
                {
                    new HtmlAttribute("class", "abc"),
                    new HtmlAttribute("id", ""),
                    new HtmlAttribute("style", "def")
                });
            Assert.Equal(expected, HtmlElement.Parse(@"<div class='abc' id='' style='def'></div>"));
        }

        [Fact]
        public void NonVoidElement_OneNonEmptyNonVoidNonDelimetedAttribute_NoChildren_NoInnerText_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("div").WithAttribute(new HtmlAttribute("class", "abc"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div class=abc></div>"));
        }

        [Fact]
        public void NonVoidElement_MultipleNonEmptyNonVoidNonDelimetedAttribute_NoChildren_NoInnerText_NoWhitespace()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithAttributes(new HtmlAttribute[]
                {
                    new HtmlAttribute("class", "abc"),
                    new HtmlAttribute("style", "def")
                });
            Assert.Equal(expected, HtmlElement.Parse(@"<div class=abc style=def></div>"));
        }

        [Fact]
        public void NonVoidElement_MultipleAttributes_NoChildren_NoInnerText()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithAttributes(new HtmlAttribute[]
                {
                    new HtmlAttribute("class", "abc"),
                    new HtmlAttribute("id", "def"),
                    new HtmlAttribute("allowfullscreen"),
                    new HtmlAttribute("style", "")
                });

            Assert.Equal(expected, HtmlElement.Parse(@"<div class=""abc"" id=""def"" allowfullscreen style=""""></div>"));
        }

        [Fact]
        public void Comment_LowercaseValue()
        {
            HtmlElement expected = new HtmlElement("div").WithChild(new HtmlComment("comment"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div><!--comment--></div>"));
        }

        [Fact]
        public void Comment_UppercaseValue()
        {
            HtmlElement expected = new HtmlElement("div").WithChild(new HtmlComment("COMMENT"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div><!--COMMENT--></div>"));
        }

        [Fact]
        public void Comment_MixedCaseValue()
        {
            HtmlElement expected = new HtmlElement("div").WithChild(new HtmlComment("CoMmEnT"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div><!--CoMmEnT--></div>"));
        }

        [Fact]
        public void Comment_LeadingAndTrailingWhitespace()
        {
            HtmlElement expected = new HtmlElement("div").WithChild(new HtmlComment(" comment "));
            Assert.Equal(expected, HtmlElement.Parse(@"<div><!-- comment --></div>"));
        }

        [Fact]
        public void Comment_OnlyWhitespace()
        {
            HtmlElement expected = new HtmlElement("div").WithChild(new HtmlComment("  "));
            Assert.Equal(expected, HtmlElement.Parse(@"<div><!--  --></div>"));
        }

        [Fact]
        public void Comment_Empty()
        {
            HtmlElement expected = new HtmlElement("div").WithChild(new HtmlComment(""));
            Assert.Equal(expected, HtmlElement.Parse(@"<div><!----></div>"));
        }

        [Fact]
        public void Doctype_HtmlWithElement_NoWhitespace()
        {
            HtmlElement expected = new HtmlDocument() { Doctype = new HtmlDoctype(HtmlDoctypeType.Html5) };
            Assert.Equal(expected, HtmlElement.Parse(@"<!DOCTYPE html><html></html>"));
        }

        [Fact]
        public void Doctype_HtmlWithDocument_NoWhitespace()
        {
            HtmlElement expected = new HtmlDocument() { Doctype = new HtmlDoctype(HtmlDoctypeType.Html5) };
            Assert.Equal(expected, HtmlDocument.Parse(@"<!DOCTYPE html><html></html>"));
        }

        [Fact]
        public void NonVoidElement_OneNonEmptyNonVoidAttribute_NoWhitespace_Unicode()
        {
            HtmlElement expected = new HtmlElement("body").WithAttribute(new HtmlAttribute("\u2345", "\u3456"));
            Assert.Equal(expected, HtmlElement.Parse("<body \u2345=\"\u3456\"></body>"));
        }

        [Fact]
        public void VoidElement_OneNonEmptyNonVoidAttribute_NoWhitespace_Unicode()
        {
            HtmlElement expected = new HtmlElement("body", isVoid: true).WithAttribute(new HtmlAttribute("\u2345", "\u3456"));
            Assert.Equal(expected, HtmlElement.Parse("<body \u2345=\"\u3456\"/>"));
        }

        public static IEnumerable<object[]> Parse_InvalidElement_TestData()
        {
            // Empty
            yield return new object[] { "" };
            yield return new object[] { "   " };

            // No opening tag
            yield return new object[] { "<" };
            yield return new object[] { "<  " };
            yield return new object[] { "<1" };
            yield return new object[] { "<>" };
            yield return new object[] { "Text" };

            // Opening tag not closed
            yield return new object[] { "<abc" };
            yield return new object[] { "<abc  " };
            yield return new object[] { "<abc/" };
            yield return new object[] { "<abc  /" };
            yield return new object[] { "<abc/   " };
            yield return new object[] { "<abc//" };

            // Invalid void tag
            yield return new object[] { "<abc/>a" };

            // Invalid attribute
            yield return new object[] { "<abc !" };
            yield return new object[] { "<abc attribute" };
            yield return new object[] { "<abc attribute/" };
            yield return new object[] { "<abc attribute=" };
            yield return new object[] { "<abc attribute=/" };
            yield return new object[] { "<abc attribute=/></abc>" };
            yield return new object[] { "<abc attribute=></abc>" };
            yield return new object[] { "<abc attribute=\"" };
            yield return new object[] { "<abc attribute=\"a" };
            yield return new object[] { "<abc attribute=\"\"" };
            yield return new object[] { "<abc attribute=!" };
            yield return new object[] { "<abc attribute=\">" };
            yield return new object[] { "<abc attribute=\"/" };
            yield return new object[] { "<abc attribute=\"/></abc>" };
            yield return new object[] { "<abc attribute='" };
            yield return new object[] { "<abc attribute='a" };
            yield return new object[] { "<abc attribute=''" };
            yield return new object[] { "<abc attribute='>" };
            yield return new object[] { "<abc attribute='/></abc>" };
            yield return new object[] { "<abc attribute=a" };
            yield return new object[] { "<abc attribute=!" };
            yield return new object[] { "<abc attribute=abc\"" };
            yield return new object[] { "<abc attribute=\"abc'></abc>" };
            yield return new object[] { "<abc attribute='abc\"></abc>" };

            // No closing tag
            yield return new object[] { "<abc>" };
            yield return new object[] { "<abc><def>" };
            yield return new object[] { "<abc><def/>" };
            yield return new object[] { "<abc><def></def>" };
            yield return new object[] { "<abc>  " };
            yield return new object[] { "<abc>InnerText" };
            yield return new object[] { "<abc>InnerText<p></p>" };
            yield return new object[] { "<abc>InnerText<p></p>MoreInnerText" };
            yield return new object[] { "<abc>InnerText<p>MoreInnerText" };
            yield return new object[] { "<abc>InnerText<p>MoreInnerText</p>" };
            yield return new object[] { "<abc>InnerText<p>" };
            yield return new object[] { "<abc>InnerText<p/>" };
            yield return new object[] { "<abc>InnerText<p/>MoreInnerText" };

            // Invalid closing tag
            yield return new object[] { "<abc>InnerText<" };
            yield return new object[] { "<abc>InnerText<  " };
            yield return new object[] { "<abc>InnerText</" };
            yield return new object[] { "<abc>InnerText</!" };
            yield return new object[] { "<abc>InnerText</abc" };
            yield return new object[] { "<abc>InnerText</abc  " };
            yield return new object[] { "<abc>InnerText</abc/" };
            yield return new object[] { "<abc>InnerText</def>" };
            yield return new object[] { "<abc>InnerText</abcd>" };
            yield return new object[] { "<abc>InnerText</ab>" };

            // Invalid comment
            yield return new object[] { "<!" };
            yield return new object[] { "<!a" };
            yield return new object[] { "<div><!a></div>" };
            yield return new object[] { "<!-" };
            yield return new object[] { "<!--" };
            yield return new object[] { "<!-a" };
            yield return new object[] { "<!--a" };
            yield return new object[] { "<!--a-" };
            yield return new object[] { "<!--a-a" };
            yield return new object[] { "<!--a--" };

            // Comment on its own
            yield return new object[] { "<!--comment-->" };
            yield return new object[] { "<!-- comment -->" };
            yield return new object[] { "<!---->" };
            yield return new object[] { "<!-- \r \t \n -->" };

            // Invalid doctype
            yield return new object[] { "<!DOCTYPE" };
            yield return new object[] { "<!DOCTYPE>a" };

            // Doctype on its own
            yield return new object[] { "<!DOCTYPE html>" };
        }

        [Theory]
        [MemberData(nameof(Parse_InvalidElement_TestData))]
        public void InvalidElement_ReturnsNull(string text)
        {
            Assert.Null(HtmlElement.Parse(text));
        }

        public static IEnumerable<object[]> Parse_InvalidDocument_TestData()
        {
            yield return new object[] { "<html>" };
            yield return new object[] { "<div></div>" };
        }

        [Theory]
        [MemberData(nameof(Parse_InvalidElement_TestData))]
        [MemberData(nameof(Parse_InvalidDocument_TestData))]
        public void InvalidDocument_ReturnsNull(string text)
        {
            Assert.Null(HtmlDocument.Parse(text));
        }
    }
}
