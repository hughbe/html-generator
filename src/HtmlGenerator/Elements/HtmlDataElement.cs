namespace HtmlGenerator
{
    public class HtmlDataElement : HtmlElement
    {
        public HtmlDataElement() : base("data") { }

        public HtmlDataElement WithValue(string value) => this.WithAttribute(Attribute.Value(value));
    }
}
