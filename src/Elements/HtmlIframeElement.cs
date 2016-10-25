namespace HtmlGenerator.Elements
{
    public class HtmlIframeElement : HtmlElement
    {
        public HtmlIframeElement() : base("iframe") { }

        public HtmlIframeElement WithAllowFullScreen() => this.WithAttribute(Attribute.AllowFullScreen);

        public HtmlIframeElement WithHeight(string value) => this.WithAttribute(Attribute.Height(value));

        public HtmlIframeElement WithName(string value) => this.WithAttribute(Attribute.Name(value));

        public HtmlIframeElement WithSandbox() => this.WithAttribute(Attribute.Sandbox);

        public HtmlIframeElement WithSeamless() => this.WithAttribute(Attribute.Seamless);

        public HtmlIframeElement WithSrc(string value) => this.WithAttribute(Attribute.Src(value));

        public HtmlIframeElement WithSrcDoc(string value) => this.WithAttribute(Attribute.SrcDoc(value));

        public HtmlIframeElement WithWidth(string value) => this.WithAttribute(Attribute.Width(value));
    }
}
