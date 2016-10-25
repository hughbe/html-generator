namespace HtmlGenerator.Elements
{
    public class HtmlSourceElement : HtmlElement
    {
        public HtmlSourceElement() : base("source", isVoid: true) { }

        public HtmlSourceElement WithSrc(string value) => this.WithAttribute(Attribute.Src(value));

        public HtmlSourceElement WithType(string value) => this.WithAttribute(Attribute.Type(value));
    }
}
