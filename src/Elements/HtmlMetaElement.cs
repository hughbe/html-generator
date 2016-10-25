namespace HtmlGenerator.Elements
{
    public class HtmlMetaElement : HtmlElement
    {
        public HtmlMetaElement() : base("meta", isVoid: true) { }

        public HtmlMetaElement WithCharset(string value) => this.WithAttribute(Attribute.Charset(value));

        public HtmlMetaElement WithContent(string value) => this.WithAttribute(Attribute.Content(value));

        public HtmlMetaElement WithHttpEquiv(string value) => this.WithAttribute(Attribute.HttpEquiv(value));

        public HtmlMetaElement WithDefaultStyle(string value) => this.WithAttribute(Attribute.DefaultStyle(value));

        public HtmlMetaElement WithRefresh(string value) => this.WithAttribute(Attribute.Refresh(value));

        public HtmlMetaElement WithName(string value) => this.WithAttribute(Attribute.Name(value));
    }
}
