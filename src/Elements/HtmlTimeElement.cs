namespace HtmlGenerator.Elements
{
    public class HtmlTimeElement : HtmlElement
    {
        public HtmlTimeElement() : base("time") { }

        public HtmlTimeElement WithDateTime(string value) => this.WithAttribute(Attribute.DateTime(value));
    }
}
