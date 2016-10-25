namespace HtmlGenerator.Elements
{
    public class HtmlColgroupElement : HtmlElement
    {
        public HtmlColgroupElement() : base("colgroup") { }

        public HtmlColgroupElement WithSpan(string value) => this.WithAttribute(Attribute.Span(value));
    }
}
