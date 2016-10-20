using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class TagTests
    {
        [Fact]
        public void TagConstructors()
        {
            VerifyElement(Tag.A, "a", false, "Download", "Href", "HrefLang", "Media", "Ping", "Rel", "Target", "Type");
            VerifyElement(Tag.Abbr, "abbr", false);
            VerifyElement(Tag.Address, "address", false);
            VerifyElement(Tag.Area, "area", true, "Alt", "Coords", "Download", "Href", "HrefLang", "Media", "Rel", "Shape", "Target", "Type");
            VerifyElement(Tag.Article, "article", false);
            VerifyElement(Tag.Audio, "audio", false, "AutoPlay", "Controls", "Loop", "Muted", "Preload", "Src", "Volume");

            VerifyElement(Tag.B, "b", false);
            VerifyElement(Tag.Base, "base", true, "Href", "Target");
            VerifyElement(Tag.Bdi, "bdi", false);
            VerifyElement(Tag.Body, "body", false);
            VerifyElement(Tag.Br, "br", true);
            VerifyElement(Tag.Button, "button", false, "AutoFocus", "Disabled", "Form", "FormAction", "FormEncType", "FormMethod", "FormNoValidate", "FormTarget", "Name", "Type", "Value");

            VerifyElement(Tag.Canvas, "canvas", false, "Height", "Width");
            VerifyElement(Tag.Caption, "caption", false);
            VerifyElement(Tag.Cite, "cite", false);
            VerifyElement(Tag.Code, "code", false);
            VerifyElement(Tag.Col, "col", true, "Span");
            VerifyElement(Tag.Colgroup, "colgroup", false, "Span");

            VerifyElement(Tag.Data, "data", false, "Value");
            VerifyElement(Tag.Datalist, "datalist", false);
            VerifyElement(Tag.Dd, "dd", false, "NoWrap");
            VerifyElement(Tag.Del, "del", false, "Cite", "DateTime");
            VerifyElement(Tag.Details, "details", false, "Open");
            VerifyElement(Tag.Dfn, "dfn", false);
            VerifyElement(Tag.Dialog, "dialog", false, "Open");
            VerifyElement(Tag.Div, "div", false);
            VerifyElement(Tag.Dl, "dl", false, "Compact");
            VerifyElement(Tag.Dt, "dt", false);

            VerifyElement(Tag.Em, "em", false);
            VerifyElement(Tag.Embed, "embed", true, "Height", "Src", "Type", "Width");

            VerifyElement(Tag.Fieldset, "fieldset", false);
            VerifyElement(Tag.FigCaption, "figcaption", false);
            VerifyElement(Tag.Figure, "figure", false);
            VerifyElement(Tag.Footer, "footer", false);
            VerifyElement(Tag.Form, "form", false, "AcceptCharset", "Action", "AutoComplete", "EncType", "Method", "Name", "NoValidate", "Target");

            VerifyElement(Tag.H1, "h1", false);
            VerifyElement(Tag.H2, "h2", false);
            VerifyElement(Tag.H3, "h3", false);
            VerifyElement(Tag.H4, "h4", false);
            VerifyElement(Tag.H5, "h5", false);
            VerifyElement(Tag.H6, "h6", false);
            VerifyElement(Tag.Head, "head", false);
            VerifyElement(Tag.Header, "header", false);
            VerifyElement(Tag.Hr, "hr", true, "Color");
            VerifyElement(Tag.Html, "html", false, "Xmls");

            VerifyElement(Tag.I, "i", false);
            VerifyElement(Tag.Iframe, "iframe", false, "AllowFullScreen", "Height", "Name", "Sandbox", "Seamless", "Src", "SrcDoc", "Width");
            VerifyElement(Tag.Img, "img", true, "Alt", "CrossOrigin", "Height", "IsMap", "LongDesc", "Sizes", "Src", "SrcSet", "Width", "UseMap");
            VerifyElement(Tag.Input, "input", true, "Accept", "AutoComplete", "AutoFocus", "AutoSave", "Checked", "Disabled", "Form", "FormAction", "FormEncType", "FormMethod", "FormNoValidate", "FormTarget", "Height", "InputMode", "List", "Max", "MaxLength", "Min", "MinLength", "Multiple", "Name", "Pattern", "Placeholder", "Readonly", "Required", "SelectionDirection", "Size", "Src", "Step", "Type", "Value", "Width");
            VerifyElement(Tag.Ins, "ins", false, "Cite", "DateTime");

            VerifyElement(Tag.Kbd, "kbd", false);

            VerifyElement(Tag.Label, "label", false, "For", "Form");
            VerifyElement(Tag.Legend, "legend", false);
            VerifyElement(Tag.Li, "li", false, "Value");
            VerifyElement(Tag.Link, "link", true, "CrossOrigin", "Href", "HrefLang", "Integrity", "Media", "Rel", "Sizes", "Type");

            VerifyElement(Tag.Main, "main", false);
            VerifyElement(Tag.Map, "map", false, "Name");
            VerifyElement(Tag.Mark, "mark", false);
            VerifyElement(Tag.Menu, "menu", false, "Label", "Type");
            VerifyElement(Tag.MenuItem, "menuitem", false, "Checked", "Command", "Default", "Disabled", "Icon", "Label", "RadioGroup", "Type");
            VerifyElement(Tag.Meta, "meta", true, "Charset", "Content", "HttpEquiv", "DefaultStyle", "Refresh", "Name");
            VerifyElement(Tag.Meter, "meter", false, "Form", "Low", "High", "Min", "Max", "Optimum", "Value");

            VerifyElement(Tag.Nav, "nav", false);
            VerifyElement(Tag.Noscript, "noscript", false);

            VerifyElement(Tag.Object, "object", false, "Data", "Form", "Height", "Name", "Type", "TypeMustMatch", "UseMap", "Width");
            VerifyElement(Tag.Ol, "ol", false, "Reversed", "Start", "Type");
            VerifyElement(Tag.Optgroup, "optgroup", false, "Disabled", "Label");
            VerifyElement(Tag.Option, "option", false, "Disabled", "Label", "Selected", "Value");
            VerifyElement(Tag.Output, "output", false, "For", "Form", "Name");

            VerifyElement(Tag.P, "p", false);
            VerifyElement(Tag.Param, "param", true, "Name", "Value");
            VerifyElement(Tag.Pre, "pre", false);
            VerifyElement(Tag.Progress, "progress", false, "Max", "Value");

            VerifyElement(Tag.Q, "q", false, "Cite");

            VerifyElement(Tag.Rp, "rp", false);
            VerifyElement(Tag.Rt, "rt", false);
            VerifyElement(Tag.Rtc, "rtc", false);
            VerifyElement(Tag.Ruby, "ruby", false);

            VerifyElement(Tag.Samp, "samp", false);
            VerifyElement(Tag.Script, "script", false, "Async", "CrossOrigin", "Defer", "Integrity", "Src", "Text", "Type");
            VerifyElement(Tag.Section, "section", false);
            VerifyElement(Tag.Select, "select", false, "AutoFocus", "Disabled", "Form", "Multiple", "Name", "Required", "Size");
            VerifyElement(Tag.Small, "small", false);
            VerifyElement(Tag.Source, "source", true, "Src", "Type");
            VerifyElement(Tag.Span, "span", false);
            VerifyElement(Tag.Strong, "strong", false);
            VerifyElement(Tag.Style, "style", false, "Disabled", "Type", "Media", "Scoped");
            VerifyElement(Tag.Sub, "sub", false);
            VerifyElement(Tag.Summary, "summary", false);
            VerifyElement(Tag.Sup, "sup", false);

            VerifyElement(Tag.Table, "table", false);
            VerifyElement(Tag.Tbody, "tbody", false);
            VerifyElement(Tag.Td, "td", false);
            VerifyElement(Tag.Template, "template", false);
            VerifyElement(Tag.TextArea, "textarea", false, "AutoComplete", "AutoFocus", "Cols", "Disabled", "Form", "MaxLength", "MinLength", "Name", "Placeholder", "Readonly", "Required", "Rows", "SelectionDirection", "Wrap");
            VerifyElement(Tag.Tfoot, "tfoot", false);
            VerifyElement(Tag.Th, "th", false, "ColSpan", "Headers", "RowSpan", "Scope");
            VerifyElement(Tag.Thead, "thead", false);
            VerifyElement(Tag.Time, "time", false, "DateTime");
            VerifyElement(Tag.Tr, "tr", false);
            VerifyElement(Tag.Track, "track", true, "Default", "Kind", "Label", "Src", "SrcLang");

            VerifyElement(Tag.U, "u", false);
            VerifyElement(Tag.Ul, "ul", false);

            VerifyElement(Tag.Var, "var", false);
            VerifyElement(Tag.Video, "video", false, "AutoPlay", "Controls", "CrossOrigin", "Height", "Loop", "Muted", "Preload", "Src", "Width");

            VerifyElement(Tag.Wbr, "wbr", false);
        }

        [Fact]
        public void Css()
        {
            HtmlElement css = Tag.Css("styles.css");
            VerifyElement(css, "link", true);

            Helpers.SerializeIgnoringFormatting(css, "<link rel=\"stylesheet\" href=\"styles.css\" />");
        }

        [Fact]
        public void Header1()
        {
            HtmlElement header1 = Tag.Header1("Text");
            VerifyElement(header1, "h1", false);

            Helpers.SerializeIgnoringFormatting(header1, "<h1>Text</h1>");
        }

        [Fact]
        public void Header2()
        {
            HtmlElement header2 = Tag.Header2("Text");
            VerifyElement(header2, "h2", false);

            Helpers.SerializeIgnoringFormatting(header2, "<h2>Text</h2>");
        }

        [Fact]
        public void Header3()
        {
            HtmlElement header3 = Tag.Header3("Text");
            VerifyElement(header3, "h3", false);

            Helpers.SerializeIgnoringFormatting(header3, "<h3>Text</h3>");
        }

        [Fact]
        public void Header4()
        {
            HtmlElement header4 = Tag.Header4("Text");
            VerifyElement(header4, "h4", false);

            Helpers.SerializeIgnoringFormatting(header4, "<h4>Text</h4>");
        }

        [Fact]
        public void Header5()
        {
            HtmlElement header5 = Tag.Header5("Text");
            VerifyElement(header5, "h5", false);

            Helpers.SerializeIgnoringFormatting(header5, "<h5>Text</h5>");
        }

        [Fact]
        public void Header6()
        {
            HtmlElement header6 = Tag.Header6("Text");
            VerifyElement(header6, "h6", false);

            Helpers.SerializeIgnoringFormatting(header6, "<h6>Text</h6>");
        }

        [Fact]
        public void Hyperlink()
        {
            HtmlElement a = Tag.Hyperlink("index.html", "Text");
            VerifyElement(a, "a", false);

            Helpers.SerializeIgnoringFormatting(a, "<a href=\"index.html\">Text</a>");
        }

        [Fact]
        public void Image_String()
        {
            HtmlElement img = Tag.Image("img.jpeg");
            VerifyElement(img, "img", true);

            Helpers.SerializeIgnoringFormatting(img, "<img src=\"img.jpeg\" alt=\"\" />");
        }

        [Fact]
        public void Image_String_String()
        {
            HtmlElement img = Tag.Image("img.jpeg", "alt-text");
            VerifyElement(img, "img", true);

            Helpers.SerializeIgnoringFormatting(img, "<img src=\"img.jpeg\" alt=\"alt-text\" />");
        }

        [Fact]
        public void Javascript()
        {
            HtmlElement script = Tag.Javascript("scripts.js");
            VerifyElement(script, "script", false);

            Helpers.SerializeIgnoringFormatting(script, "<script src=\"scripts.js\"></script>");
        }

        [Fact]
        public void ListItem()
        {
            HtmlElement li = Tag.ListItem("Text");
            VerifyElement(li, "li", false);

            Helpers.SerializeIgnoringFormatting(li, "<li>Text</li>");
        }

        [Fact]
        public void Meta()
        {
            HtmlElement meta = Tag.Metadata("Name", "Content");
            VerifyElement(meta, "meta", true);

            Helpers.SerializeIgnoringFormatting(meta, "<meta name=\"Name\" content=\"Content\" />");
        }

        [Fact]
        public void Paragraph()
        {
            HtmlElement p = Tag.Paragraph("Text");
            VerifyElement(p, "p", false);

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

        private static void VerifyElement(HtmlElement element, string tag, bool isVoid, params string[] attributeNames)
        {
            Assert.Equal(tag, element.Tag);
            Assert.Equal(isVoid, element.IsVoid);
            Assert.Null(element.Parent);

            foreach (string attributeName in attributeNames)
            {
                bool attributeIsVoid = typeof(Attribute).GetMethod(attributeName) == null;
                MethodInfo method = element.GetType().GetMethod("With" + attributeName);
                if (attributeIsVoid)
                {
                    HtmlAttribute expectedAttribute = (HtmlAttribute)typeof(Attribute).GetProperty(attributeName).GetValue(null);   

                    Assert.Empty(method.GetParameters());
                    Assert.Same(element, method.Invoke(element, new object[0]));

                    HtmlAttribute actualAttribute;
                    Assert.True(element.TryGetAttribute(expectedAttribute.Name, out actualAttribute));
                    Assert.Equal(expectedAttribute, actualAttribute);
                }
                else
                {
                    HtmlAttribute expectedAttribute = (HtmlAttribute)typeof(Attribute).GetMethod(attributeName).Invoke(null, new object[] { "value" });

                    Assert.Equal(new Type[] { typeof(string) }, method.GetParameters().Select(parameter => parameter.ParameterType));
                    Assert.Same(element, method.Invoke(element, new object[] { "value" }));

                    HtmlAttribute actualAttribute;
                    Assert.True(element.TryGetAttribute(expectedAttribute.Name, out actualAttribute));
                    Assert.Equal(expectedAttribute, actualAttribute);
                }
            }
        }

        [Fact]
        public void WithInnerText()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Same(element, element.WithInnerText("InnerText"));
            Assert.Equal(new HtmlNode[] { new HtmlText("InnerText") }, element.Nodes());
        }

        [Fact]
        public void WithElement_WithElements()
        {
            HtmlElement element = new HtmlElement("html");

            HtmlElement element1 = new HtmlElement("h1");
            Assert.Same(element, element.WithChild(element1));
            Assert.Equal(new HtmlElement[] { element1 }, element.Elements());

            HtmlElement element2 = new HtmlElement("h2");
            Assert.Same(element, element.WithChildren(new HtmlElement[] { element2 }));
            Assert.Equal(new HtmlElement[] { element1, element2 }, element.Elements());
        }

        [Fact]
        public void WithAttribute_WithAttributes()
        {
            HtmlElement element = new HtmlElement("html");

            HtmlAttribute attribute1 = new HtmlAttribute("Attribute1");
            Assert.Same(element, element.WithAttribute(attribute1));
            Assert.Equal(new HtmlAttribute[] { attribute1 }, element.Attributes());

            HtmlAttribute attribute2 = new HtmlAttribute("Attribute2");
            Assert.Same(element, element.WithAttributes(new HtmlAttribute[] { attribute2 }));
            Assert.Equal(new HtmlAttribute[] { attribute1, attribute2 }, element.Attributes());
        }

        [Fact]
        public void WithAccessKey()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithAccessKey("value"));
            Assert.Equal(Attribute.AccessKey("value"), element.Attributes().First());
        }

        [Fact]
        public void WithClass()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithClass("value"));
            Assert.Equal(Attribute.Class("value"), element.Attributes().First());
        }

        [Fact]
        public void WithContentEditable()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithContentEditable("value"));
            Assert.Equal(Attribute.ContentEditable("value"), element.Attributes().First());
        }

        [Fact]
        public void WithContextMenu()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithContextMenu("value"));
            Assert.Equal(Attribute.ContextMenu("value"), element.Attributes().First());
        }

        [Fact]
        public void WithDir()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithDir("value"));
            Assert.Equal(Attribute.Dir("value"), element.Attributes().First());
        }

        [Fact]
        public void WithHidden()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithHidden("value"));
            Assert.Equal(Attribute.Hidden("value"), element.Attributes().First());
        }

        [Fact]
        public void WithId()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithId("value"));
            Assert.Equal(Attribute.Id("value"), element.Attributes().First());
        }

        [Fact]
        public void WithLang()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithLang("value"));
            Assert.Equal(Attribute.Lang("value"), element.Attributes().First());
        }

        [Fact]
        public void WithSpellCheck()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithSpellCheck("value"));
            Assert.Equal(Attribute.SpellCheck("value"), element.Attributes().First());
        }

        [Fact]
        public void WithStyle()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithStyle("value"));
            Assert.Equal(Attribute.Style("value"), element.Attributes().First());
        }

        [Fact]
        public void WithTabIndex()
        {
            HtmlElement element = new HtmlElement("html");
            Assert.Same(element, element.WithTabIndex("value"));
            Assert.Equal(Attribute.TabIndex("value"), element.Attributes().First());
        }
    }
}
