namespace HtmlGenerator.Elements
{
    public class HtmlDelElement : HtmlElement
    {
        public HtmlDelElement() : base("del") { }

        public HtmlDelElement WithCite(string value) => this.WithAttribute(Attribute.Cite(value));

        public HtmlDelElement WithDateTime(string value) => this.WithAttribute(Attribute.DateTime(value));
    }
}
