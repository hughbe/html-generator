using System;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class TagTests
    {
        [Fact]
        public void TagConstructors()
        {
            VerifyElement(Tag.A, "a", false);
            VerifyElement(Tag.Abbr, "abbr", false);
            VerifyElement(Tag.Address, "address", false);
            VerifyElement(Tag.Area, "area", true);
            VerifyElement(Tag.Article, "article", false);
            VerifyElement(Tag.Audio, "audio", false);

            VerifyElement(Tag.B, "b", false);
            VerifyElement(Tag.Base, "base", true);
            VerifyElement(Tag.Bdi, "bdi", false);
            VerifyElement(Tag.Body, "body", false);
            VerifyElement(Tag.Br, "br", true);
            VerifyElement(Tag.Button, "button", false);

            VerifyElement(Tag.Canvas, "canvas", false);
            VerifyElement(Tag.Caption, "caption", false);
            VerifyElement(Tag.Cite, "cite", false);
            VerifyElement(Tag.Code, "code", false);
            VerifyElement(Tag.Col, "col", true);
            VerifyElement(Tag.Colgroup, "colgroup", false);

            VerifyElement(Tag.Data, "data", false);
            VerifyElement(Tag.Datalist, "datalist", false);
            VerifyElement(Tag.Dd, "dd", false);
            VerifyElement(Tag.Del, "del", false);
            VerifyElement(Tag.Details, "details", false);
            VerifyElement(Tag.Dfn, "dfn", false);
            VerifyElement(Tag.Dialog, "dialog", false);
            VerifyElement(Tag.Div, "div", false);
            VerifyElement(Tag.Dl, "dl", false);
            VerifyElement(Tag.Dt, "dt", false);

            VerifyElement(Tag.Em, "em", false);
            VerifyElement(Tag.Embed, "embed", true);

            VerifyElement(Tag.Fieldset, "fieldset", false);
            VerifyElement(Tag.FigCaption, "figcaption", false);
            VerifyElement(Tag.Figure, "figure", false);
            VerifyElement(Tag.Footer, "footer", false);
            VerifyElement(Tag.Form, "form", false);

            VerifyElement(Tag.H1, "h1", false);
            VerifyElement(Tag.H2, "h2", false);
            VerifyElement(Tag.H3, "h3", false);
            VerifyElement(Tag.H4, "h4", false);
            VerifyElement(Tag.H5, "h5", false);
            VerifyElement(Tag.H6, "h6", false);
            VerifyElement(Tag.Head, "head", false);
            VerifyElement(Tag.Header, "header", false);
            VerifyElement(Tag.Hr, "hr", true);
            VerifyElement(Tag.Html, "html", false);

            VerifyElement(Tag.I, "i", false);
            VerifyElement(Tag.Iframe, "iframe", false);
            VerifyElement(Tag.Img, "img", true);
            VerifyElement(Tag.Input, "input", true);
            VerifyElement(Tag.Ins, "ins", false);

            VerifyElement(Tag.Kbd, "kbd", false);

            VerifyElement(Tag.Label, "label", false);
            VerifyElement(Tag.Legend, "legend", false);
            VerifyElement(Tag.Li, "li", false);
            VerifyElement(Tag.Link, "link", true);
            VerifyElement(Tag.Main, "main", false);
            VerifyElement(Tag.Map, "map", false);
            VerifyElement(Tag.Mark, "mark", false);
            VerifyElement(Tag.Menu, "menu", false);
            VerifyElement(Tag.MenuItem, "menuitem", false);
            VerifyElement(Tag.Meta, "meta", true);
            VerifyElement(Tag.Meter, "meter", false);

            VerifyElement(Tag.Nav, "nav", false);
            VerifyElement(Tag.Noscript, "noscript", false);

            VerifyElement(Tag.Object, "object", false);
            VerifyElement(Tag.Ol, "ol", false);
            VerifyElement(Tag.Optgroup, "optgroup", false);
            VerifyElement(Tag.Option, "option", false);
            VerifyElement(Tag.Output, "output", false);

            VerifyElement(Tag.P, "p", false);
            VerifyElement(Tag.Param, "param", true);
            VerifyElement(Tag.Pre, "pre", false);
            VerifyElement(Tag.Progress, "progress", false);

            VerifyElement(Tag.Q, "q", false);

            VerifyElement(Tag.Rp, "rp", false);
            VerifyElement(Tag.Rt, "rt", false);
            VerifyElement(Tag.Rtc, "rtc", false);
            VerifyElement(Tag.Ruby, "ruby", false);

            VerifyElement(Tag.Samp, "samp", false);
            VerifyElement(Tag.Script, "script", false);
            VerifyElement(Tag.Section, "section", false);
            VerifyElement(Tag.Select, "select", false);
            VerifyElement(Tag.Small, "small", false);
            VerifyElement(Tag.Source, "source", true);
            VerifyElement(Tag.Span, "span", false);
            VerifyElement(Tag.Strong, "strong", false);
            VerifyElement(Tag.Style, "style", false);
            VerifyElement(Tag.Sub, "sub", false);
            VerifyElement(Tag.Summary, "summary", false);
            VerifyElement(Tag.Sup, "sup", false);

            VerifyElement(Tag.Table, "table", false);
            VerifyElement(Tag.Tbody, "tbody", false);
            VerifyElement(Tag.Td, "td", false);
            VerifyElement(Tag.Template, "template", false);
            VerifyElement(Tag.TextArea, "textarea", false);
            VerifyElement(Tag.Tfoot, "tfoot", false);
            VerifyElement(Tag.Th, "th", false);
            VerifyElement(Tag.Thead, "thead", false);
            VerifyElement(Tag.Time, "time", false);
            VerifyElement(Tag.Tr, "tr", false);
            VerifyElement(Tag.Track, "track", true);

            VerifyElement(Tag.U, "u", false);
            VerifyElement(Tag.Ul, "ul", false);

            VerifyElement(Tag.Var, "var", false);
            VerifyElement(Tag.Video, "video", false);

            VerifyElement(Tag.Wbr, "wbr", false);
        }

        [Fact]
        public void Css()
        {
            HtmlElement css = Tag.Css("styles.css");
            VerifyElement(css, "link", true, modify: false);

            Helpers.SerializeIgnoringFormatting(css, "<link rel=\"stylesheet\" href=\"styles.css\" />");
        }

        [Fact]
        public void Header1()
        {
            HtmlElement header1 = Tag.Header1("Text");
            VerifyElement(header1, "h1", false, modify: false);

            Helpers.SerializeIgnoringFormatting(header1, "<h1>Text</h1>");
        }

        [Fact]
        public void Header2()
        {
            HtmlElement header2 = Tag.Header2("Text");
            VerifyElement(header2, "h2", false, modify: false);

            Helpers.SerializeIgnoringFormatting(header2, "<h2>Text</h2>");
        }

        [Fact]
        public void Header3()
        {
            HtmlElement header3 = Tag.Header3("Text");
            VerifyElement(header3, "h3", false, modify: false);

            Helpers.SerializeIgnoringFormatting(header3, "<h3>Text</h3>");
        }

        [Fact]
        public void Header4()
        {
            HtmlElement header4 = Tag.Header4("Text");
            VerifyElement(header4, "h4", false, modify: false);

            Helpers.SerializeIgnoringFormatting(header4, "<h4>Text</h4>");
        }

        [Fact]
        public void Header5()
        {
            HtmlElement header5 = Tag.Header5("Text");
            VerifyElement(header5, "h5", false, modify: false);

            Helpers.SerializeIgnoringFormatting(header5, "<h5>Text</h5>");
        }

        [Fact]
        public void Header6()
        {
            HtmlElement header6 = Tag.Header6("Text");
            VerifyElement(header6, "h6", false, modify: false);

            Helpers.SerializeIgnoringFormatting(header6, "<h6>Text</h6>");
        }

        [Fact]
        public void Hyperlink()
        {
            HtmlElement a = Tag.Hyperlink("index.html", "Text");
            VerifyElement(a, "a", false, modify: false);

            Helpers.SerializeIgnoringFormatting(a, "<a href=\"index.html\">Text</a>");
        }

        [Fact]
        public void Image_String()
        {
            HtmlElement img = Tag.Image("img.jpeg");
            VerifyElement(img, "img", true, modify: false);

            Helpers.SerializeIgnoringFormatting(img, "<img src=\"img.jpeg\" alt=\"\" />");
        }

        [Fact]
        public void Image_String_String()
        {
            HtmlElement img = Tag.Image("img.jpeg", "alt-text");
            VerifyElement(img, "img", true, modify: false);

            Helpers.SerializeIgnoringFormatting(img, "<img src=\"img.jpeg\" alt=\"alt-text\" />");
        }
        
        [Fact]
        public void Javascript()
        {
            HtmlElement script = Tag.Javascript("scripts.js");
            VerifyElement(script, "script", false, modify: false);

            Helpers.SerializeIgnoringFormatting(script, "<script src=\"scripts.js\"></script>");
        }

        [Fact]
        public void ListItem()
        {
            HtmlElement li = Tag.ListItem("Text");
            VerifyElement(li, "li", false, modify: false);

            Helpers.SerializeIgnoringFormatting(li, "<li>Text</li>");
        }

        [Fact]
        public void Meta()
        {
            HtmlElement meta = Tag.Metadata("Name", "Content");
            VerifyElement(meta, "meta", true, modify: false);

            Helpers.SerializeIgnoringFormatting(meta, "<meta name=\"Name\" content=\"Content\" />");
        }

        [Fact]
        public void Paragraph()
        {
            HtmlElement p = Tag.Paragraph("Text");
            VerifyElement(p, "p", false, modify: false);

            Helpers.SerializeIgnoringFormatting(p, "<p>Text</p>");
        }

        [Fact]
        public void Custom_String()
        {
            HtmlElement custom = Tag.Custom("tag");
            VerifyElement(custom, "tag", false);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Custom_String_Bool(bool isVoid)
        {
            HtmlElement custom = Tag.Custom("tag", isVoid);
            VerifyElement(custom, "tag", isVoid);
        }

        public void VerifyElement(HtmlElement element, string tag, bool isVoid, bool modify = true)
        {
            Assert.Equal(tag, element.Tag);
            Assert.Equal(isVoid, element.IsVoid);
            Assert.Null(element.Parent);
            
            if (isVoid)
            {
                Assert.Throws<InvalidOperationException>(() => element.WithInnerText(""));
                Assert.Throws<InvalidOperationException>(() => element.WithElement(new HtmlElement("h1")));
                Assert.Throws<InvalidOperationException>(() => element.WithElements(new HtmlElement[] { new HtmlElement("h1") }));
            }
            else if (modify)
            {
                Assert.Same(element, element.WithInnerText("InnerText"));
                Assert.Equal("InnerText", element.InnerText);

                HtmlElement element1 = new HtmlElement("h1");
                Assert.Same(element, element.WithElement(element1));
                Assert.Equal(new HtmlElement[] { element1 }, element.Elements());

                HtmlElement element2 = new HtmlElement("h2");
                Assert.Same(element, element.WithElements(new HtmlElement[] { element2 }));
                Assert.Equal(new HtmlElement[] { element1, element2 }, element.Elements());

                HtmlAttribute attribute1 = new HtmlAttribute("Attribute1");
                Assert.Same(element, element.WithAttribute(attribute1));
                Assert.Equal(new HtmlAttribute[] { attribute1 }, element.Attributes());

                HtmlAttribute attribute2 = new HtmlAttribute("Attribute2");
                Assert.Same(element, element.WithAttributes(new HtmlAttribute[] { attribute2 }));
                Assert.Equal(new HtmlAttribute[] { attribute1, attribute2 }, element.Attributes());
            }
        }
    }
}
