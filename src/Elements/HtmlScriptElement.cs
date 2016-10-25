namespace HtmlGenerator.Elements
{
    public class HtmlScriptElement : HtmlElement
    {
        public HtmlScriptElement() : base("script") { }

        public HtmlScriptElement WithAsync(string value) => this.WithAttribute(Attribute.Async(value));

        public HtmlScriptElement WithCrossOrigin(string value) => this.WithAttribute(Attribute.CrossOrigin(value));

        public HtmlScriptElement WithDefer(string value) => this.WithAttribute(Attribute.Defer(value));

        public HtmlScriptElement WithIntegrity(string value) => this.WithAttribute(Attribute.Integrity(value));

        public HtmlScriptElement WithSrc(string value) => this.WithAttribute(Attribute.Src(value));

        public HtmlScriptElement WithText(string value) => this.WithAttribute(Attribute.Text(value));

        public HtmlScriptElement WithType(string value) => this.WithAttribute(Attribute.Type(value));
    }
}
