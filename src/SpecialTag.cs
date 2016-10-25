using HtmlGenerator.Elements;

namespace HtmlGenerator
{
    public static partial class Tag
    {
        public static HtmlLinkElement Css(string src) => new HtmlLinkElement().WithRel("stylesheet").WithHref(src);

        public static HtmlElement Header1(string innerText) => H1.WithInnerText(innerText);
        public static HtmlElement Header2(string innerText) => H2.WithInnerText(innerText);
        public static HtmlElement Header3(string innerText) => H3.WithInnerText(innerText);
        public static HtmlElement Header4(string innerText) => H4.WithInnerText(innerText);
        public static HtmlElement Header5(string innerText) => H5.WithInnerText(innerText);
        public static HtmlElement Header6(string innerText) => H6.WithInnerText(innerText);
        public static HtmlAElement Hyperlink(string href, string innerText) => new HtmlAElement().WithHref(href).WithInnerText(innerText);

        public static HtmlImgElement Image(string src) => Image(src, "");
        public static HtmlImgElement Image(string src, string alt) => new HtmlImgElement().WithSrc(src).WithAlt(alt);

        public static HtmlScriptElement Javascript(string src) => new HtmlScriptElement().WithSrc(src);

        public static HtmlLiElement ListItem(string innerText) => new HtmlLiElement().WithInnerText(innerText);

        public static HtmlMetaElement Metadata(string name, string content) => new HtmlMetaElement().WithName(name).WithContent(content);

        public static HtmlElement Paragraph(string innerText) => P.WithInnerText(innerText);

        public static HtmlElement Custom(string elementTag) => Custom(elementTag, false);
        public static HtmlElement Custom(string elementTag, bool isVoid) => new HtmlElement(elementTag, isVoid);
    }
}
