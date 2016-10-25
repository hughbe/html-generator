namespace HtmlGenerator.Elements
{
    public class HtmlProgressElement : HtmlElement
    {
        public HtmlProgressElement() : base("progress") { }

        public HtmlProgressElement WithMax(string value) => this.WithAttribute(Attribute.Max(value));

        public HtmlProgressElement WithValue(string value) => this.WithAttribute(Attribute.Value(value));
    }
}
