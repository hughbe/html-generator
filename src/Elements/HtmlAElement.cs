namespace HtmlGenerator.Elements
{
    public class HtmlAElement : HtmlElement
    {
        public HtmlAElement() : base("a") { }

        public HtmlAElement WithDownload(string value) => this.WithAttribute(Attribute.Download(value));

        public HtmlAElement WithHref(string value) => this.WithAttribute(Attribute.Href(value));

        public HtmlAElement WithHrefLang(string value) => this.WithAttribute(Attribute.HrefLang(value));

        public HtmlAElement WithMedia(string value) => this.WithAttribute(Attribute.Media(value));

        public HtmlAElement WithPing(string value) => this.WithAttribute(Attribute.Ping(value));

        public HtmlAElement WithRel(string value) => this.WithAttribute(Attribute.Rel(value));

        public HtmlAElement WithTarget(string value) => this.WithAttribute(Attribute.Target(value));

        public HtmlAElement WithType(string value) => this.WithAttribute(Attribute.Type(value));
    }
}
