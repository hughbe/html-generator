namespace HtmlGenerator
{
    public static partial class Tag
    {
        public static HtmlLinkElement Css(string src) => new HtmlLinkElement().WithRel("stylesheet").WithHref(src);

        public static HtmlH1Element Header1(string innerText) => new HtmlH1Element().WithInnerText(innerText);
        public static HtmlH2Element Header2(string innerText) => new HtmlH2Element().WithInnerText(innerText);
        public static HtmlH3Element Header3(string innerText) => new HtmlH3Element().WithInnerText(innerText);
        public static HtmlH4Element Header4(string innerText) => new HtmlH4Element().WithInnerText(innerText);
        public static HtmlH5Element Header5(string innerText) => new HtmlH5Element().WithInnerText(innerText);
        public static HtmlH6Element Header6(string innerText) => new HtmlH6Element().WithInnerText(innerText);
        public static HtmlAElement Hyperlink(string href, string innerText) => new HtmlAElement().WithHref(href).WithInnerText(innerText);

        public static HtmlImgElement Image(string src) => Image(src, "");
        public static HtmlImgElement Image(string src, string alt) => new HtmlImgElement().WithSrc(src).WithAlt(alt);
        
        public static HtmlScriptElement Javascript(string src) => new HtmlScriptElement().WithSrc(src);

        public static HtmlLiElement ListItem(string innerText) => new HtmlLiElement().WithInnerText(innerText);

        public static HtmlMetaElement Metadata(string name, string content) => new HtmlMetaElement().WithName(name).WithContent(content);

        public static HtmlPElement Paragraph(string innerText) => new HtmlPElement().WithInnerText(innerText);

        public static HtmlElement Custom(string elementTag) => Custom(elementTag, false);
        public static HtmlElement Custom(string elementTag, bool isVoid) => new HtmlElement(elementTag, isVoid);
    }
}
