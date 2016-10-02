namespace HtmlGenerator
{
    public class HtmlQElement : HtmlElement
    {
        public HtmlQElement() : base("q") { }

        public HtmlQElement WithCite(string value) => this.WithAttribute(Attribute.Cite(value));
    }
}
