namespace HtmlGenerator.Elements
{
    public class HtmlLinkElement : HtmlElement
    {
        public HtmlLinkElement() : base("link", isVoid: true) { }

        public HtmlLinkElement WithCrossOrigin(string value) => this.WithAttribute(Attribute.CrossOrigin(value));

        public HtmlLinkElement WithHref(string value) => this.WithAttribute(Attribute.Href(value));

        public HtmlLinkElement WithHrefLang(string value) => this.WithAttribute(Attribute.HrefLang(value));

        public HtmlLinkElement WithIntegrity(string value) => this.WithAttribute(Attribute.Integrity(value));

        public HtmlLinkElement WithMedia(string value) => this.WithAttribute(Attribute.Media(value));

        public HtmlLinkElement WithRel(string value) => this.WithAttribute(Attribute.Rel(value));

        public HtmlLinkElement WithSizes(string value) => this.WithAttribute(Attribute.Sizes(value));

        public HtmlLinkElement WithType(string value) => this.WithAttribute(Attribute.Type(value));
    }
}
