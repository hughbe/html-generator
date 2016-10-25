namespace HtmlGenerator.Elements
{
    public class HtmlMenuElement : HtmlElement
    {
        public HtmlMenuElement() : base("menu") { }

        public HtmlMenuElement WithLabel(string value) => this.WithAttribute(Attribute.Label(value));

        public HtmlMenuElement WithType(string value) => this.WithAttribute(Attribute.Type(value));
    }
}
