namespace HtmlGenerator.Elements
{
    public class HtmlInsElement : HtmlElement
    {
        public HtmlInsElement() : base("ins") { }

        public HtmlInsElement WithCite(string value) => this.WithAttribute(Attribute.Cite(value));

        public HtmlInsElement WithDateTime(string value) => this.WithAttribute(Attribute.DateTime(value));
    }
}
