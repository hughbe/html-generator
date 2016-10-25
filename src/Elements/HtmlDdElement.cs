namespace HtmlGenerator.Elements
{
    public class HtmlDdElement : HtmlElement
    {
        public HtmlDdElement() : base("dd") { }

        public HtmlDdElement WithNoWrap(string value) => this.WithAttribute(Attribute.NoWrap(value));
    }
}
