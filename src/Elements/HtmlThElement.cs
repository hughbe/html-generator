namespace HtmlGenerator.Elements
{
    public class HtmlThElement : HtmlElement
    {
        public HtmlThElement() : base("th") { }

        public HtmlThElement WithColSpan(string value) => this.WithAttribute(Attribute.ColSpan(value));

        public HtmlThElement WithHeaders(string value) => this.WithAttribute(Attribute.Headers(value));

        public HtmlThElement WithRowSpan(string value) => this.WithAttribute(Attribute.RowSpan(value));

        public HtmlThElement WithScope(string value) => this.WithAttribute(Attribute.Scope(value));
    }
}
