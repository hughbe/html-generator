namespace HtmlGenerator.Elements
{
    public class HtmlAreaElement : HtmlElement
    {
        public HtmlAreaElement() : base("area", isVoid: true) { }

        public HtmlAreaElement WithAlt(string value) => this.WithAttribute(Attribute.Alt(value));

        public HtmlAreaElement WithCoords(string value) => this.WithAttribute(Attribute.Coords(value));

        public HtmlAreaElement WithDownload(string value) => this.WithAttribute(Attribute.Download(value));

        public HtmlAreaElement WithHref(string value) => this.WithAttribute(Attribute.Href(value));

        public HtmlAreaElement WithHrefLang(string value) => this.WithAttribute(Attribute.HrefLang(value));

        public HtmlAreaElement WithMedia(string value) => this.WithAttribute(Attribute.Media(value));

        public HtmlAreaElement WithRel(string value) => this.WithAttribute(Attribute.Rel(value));

        public HtmlAreaElement WithShape(string value) => this.WithAttribute(Attribute.Shape(value));

        public HtmlAreaElement WithTarget(string value) => this.WithAttribute(Attribute.Target(value));

        public HtmlAreaElement WithType(string value) => this.WithAttribute(Attribute.Type(value));
    }
}
