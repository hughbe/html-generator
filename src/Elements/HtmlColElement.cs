namespace HtmlGenerator.Elements
{
    public class HtmlColElement : HtmlElement
    {
        public HtmlColElement() : base("col", isVoid: true) { }

        public HtmlColElement WithSpan(string value) => this.WithAttribute(Attribute.Span(value));
    }
}
