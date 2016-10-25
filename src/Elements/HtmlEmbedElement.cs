namespace HtmlGenerator.Elements
{
    public class HtmlEmbedElement : HtmlElement
    {
        public HtmlEmbedElement() : base("embed", isVoid: true) { }

        public HtmlEmbedElement WithHeight(string value) => this.WithAttribute(Attribute.Height(value));

        public HtmlEmbedElement WithSrc(string value) => this.WithAttribute(Attribute.Src(value));

        public HtmlEmbedElement WithType(string value) => this.WithAttribute(Attribute.Type(value));

        public HtmlEmbedElement WithWidth(string value) => this.WithAttribute(Attribute.Width(value));
    }
}
