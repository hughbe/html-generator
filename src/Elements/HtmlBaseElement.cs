namespace HtmlGenerator.Elements
{
    public class HtmlBaseElement : HtmlElement
    {
        public HtmlBaseElement() : base("base", isVoid: true) { }

        public HtmlBaseElement WithHref(string value) => this.WithAttribute(Attribute.Href(value));

        public HtmlBaseElement WithTarget(string value) => this.WithAttribute(Attribute.Target(value));
    }
}
