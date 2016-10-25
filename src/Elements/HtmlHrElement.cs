namespace HtmlGenerator.Elements
{
    public class HtmlHrElement : HtmlElement
    {
        public HtmlHrElement() : base("hr", isVoid: true) { }

        public HtmlHrElement WithColor(string value) => this.WithAttribute(Attribute.Color(value));
    }
}
