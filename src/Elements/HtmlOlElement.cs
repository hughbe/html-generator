namespace HtmlGenerator.Elements
{
    public class HtmlOlElement : HtmlElement
    {
        public HtmlOlElement() : base("ol") { }

        public HtmlOlElement WithReversed(string value) => this.WithAttribute(Attribute.Reversed(value));

        public HtmlOlElement WithStart(string value) => this.WithAttribute(Attribute.Start(value));

        public HtmlOlElement WithType(string value) => this.WithAttribute(Attribute.Type(value));
    }
}
