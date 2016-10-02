namespace HtmlGenerator
{
    public class HtmlDlElement : HtmlElement
    {
        public HtmlDlElement() : base("dl") { }

        public HtmlDlElement WithCompact(string value) => this.WithAttribute(Attribute.Compact(value));
    }
}
