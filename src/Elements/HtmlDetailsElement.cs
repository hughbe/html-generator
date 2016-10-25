namespace HtmlGenerator.Elements
{
    public class HtmlDetailsElement : HtmlElement
    {
        public HtmlDetailsElement() : base("details") { }

        public HtmlDetailsElement WithOpen(string value) => this.WithAttribute(Attribute.Open(value));
    }
}
