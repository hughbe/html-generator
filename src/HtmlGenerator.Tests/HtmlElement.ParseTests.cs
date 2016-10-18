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
        public void NonVoidElement_NoChildren_NoWhitespace_Lowercase()
        {
            Assert.Equal(new HtmlElement("div"), HtmlElement.Parse("<div></div>"));
        }

        [Fact]
        public void NonVoidElement_NoChildren_NoWhitespace_Uppercase()
        {
            Assert.Equal(new HtmlElement("div"), HtmlElement.Parse("<DIV></DIV>"));
        }
        [Fact]
        public void NonVoidElement_NoChildren_NoWhitespace_MixedCase()
        {
            Assert.Equal(new HtmlElement("div"), HtmlElement.Parse("<DiV></dIv>"));
        }

        [Fact]
        public void NonVoidElement_NoChildren_Whitespace()
        {
            Assert.Equal(new HtmlElement("div"), HtmlElement.Parse(" < div >< / div > "));
        }

        [Fact]
        public void NonVoidElement_InnerText()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithInnerText("InnerText");

            Assert.Equal(expected, HtmlElement.Parse("<div>InnerText</div>"));
        }

        [Fact]
        public void NonVoidElement_OneNonVoidChild()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithElement(new HtmlElement("p"));

            Assert.Equal(expected, HtmlElement.Parse("<div><p></p></div>"));
        }

        [Fact]
        public void NonVoidElement_OneVoidChild()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithElement(new HtmlElement("br", isVoid: true));

            Assert.Equal(expected, HtmlElement.Parse("<div><br/></div>"));
        }

        [Fact]
        public void NonVoidElement_MultipleChildren()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithElement(new HtmlElement("p"))
                .WithElement(new HtmlElement("h1"));

            Assert.Equal(expected, HtmlElement.Parse("<div><p></p><h1></h1></div>"));
        }

        [Fact]
        public void NonVoidElement_MultipleNestedChildren()
        {
            HtmlElement expected = new HtmlElement("div")
                .WithElements(new HtmlElement[]
                {
                    new HtmlElement("div").WithElements(new HtmlElement[]
                    {
                        new HtmlElement("p").WithInnerText("Text"),
                        new HtmlElement("h1")
                    }),
                    new HtmlElement("br", isVoid: true),
                    new HtmlElement("section").WithElements(new HtmlElement[]
                    {
                        new HtmlElement("div").WithElements(new HtmlElement[]
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
        public void Comment_HasValue_NoChildren_NoParents_Lowercase()
        {
            HtmlElement expected = new HtmlComment("comment");
            Assert.Equal(expected, HtmlElement.Parse(@"<!--comment-->"));
        }

        [Fact]
        public void Comment_HasValue_NoChildren_NoParents_Uppercase()
        {
            HtmlElement expected = new HtmlComment("comment");
            Assert.Equal(expected, HtmlElement.Parse(@"<!--COMMENT-->"));
        }

        [Fact]
        public void Comment_HasValue_NoChildren_NoParents_MixedCase()
        {
            HtmlElement expected = new HtmlComment("comment");
            Assert.Equal(expected, HtmlElement.Parse(@"<!--CoMmEnT-->"));
        }

        [Fact]
        public void Comment_LeadingAndTrailingWhitespace_NoChildren_NoParents()
        {
            HtmlElement expected = new HtmlComment(" comment ");
            Assert.Equal(expected, HtmlElement.Parse(@"<!-- comment -->"));
        }

        [Fact]
        public void Comment_OnlyWhitespace_NoChildren_NoParents()
        {
            HtmlElement expected = new HtmlComment("  ");
            Assert.Equal(expected, HtmlElement.Parse(@"<!--  -->"));
        }

        [Fact]
        public void Comment_Empty_NoChildren_NoParents()
        {
            HtmlElement expected = new HtmlComment("");
            Assert.Equal(expected, HtmlElement.Parse(@"<!---->"));
        }

        [Fact]
        public void Comment_Nested()
        {
            HtmlElement expected = new HtmlElement("div").WithElement(new HtmlComment("comment"));
            Assert.Equal(expected, HtmlElement.Parse(@"<div><!--comment--></div>"));
        }

        public static IEnumerable<object[]> Parse_Invalid_TestData()
        {
            // Empty
            yield return new object[] { "" };
            yield return new object[] { "   " };

            // No opening tag
            yield return new object[] { "<" };
            yield return new object[] { "<  " };
            yield return new object[] { "<1" };
            yield return new object[] { "<>" };

            // Opening tag not closed
            yield return new object[] { "<abc" };
            yield return new object[] { "<abc  " };
            yield return new object[] { "<abc/" };
            yield return new object[] { "<abc  /" };
            yield return new object[] { "<abc/   " };
            yield return new object[] { "<abc//" };

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
            yield return new object[] { "<abc>  " };
            yield return new object[] { "<abc>InnerText" };

            // Invalid closing tag
            yield return new object[] { "<abc>InnerText<" };
            yield return new object[] { "<abc>InnerText<  " };
            yield return new object[] { "<abc>InnerText</" };
            yield return new object[] { "<abc>InnerText</!" };
            yield return new object[] { "<abc>InnerText</abc" };
            yield return new object[] { "<abc>InnerText</abc  " };
            yield return new object[] { "<abc>InnerText</abc/" };
            yield return new object[] { "<abc>InnerText</def>" };

            // Invalid comment
            yield return new object[] { "<!" };
            yield return new object[] { "<!a" };
            yield return new object[] { "<!-" };
            yield return new object[] { "<!--" };
            yield return new object[] { "<!-a" };
            yield return new object[] { "<!--a" };
            yield return new object[] { "<!--a-" };
            yield return new object[] { "<!--a-a" };
            yield return new object[] { "<!--a--" };
        }

        [Theory]
        [MemberData(nameof(Parse_Invalid_TestData))]
        public void Invalid_ReturnsNull(string text)
        {
            Assert.Null(HtmlElement.Parse(text));
        }
    }
}
