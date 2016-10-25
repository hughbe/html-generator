namespace HtmlGenerator.Elements
{
    public class HtmlTrackElement : HtmlElement
    {
        public HtmlTrackElement() : base("track", isVoid: true) { }

        public HtmlTrackElement WithDefault() => this.WithAttribute(Attribute.Default);

        public HtmlTrackElement WithKind(string value) => this.WithAttribute(Attribute.Kind(value));

        public HtmlTrackElement WithLabel(string value) => this.WithAttribute(Attribute.Label(value));

        public HtmlTrackElement WithSrc(string value) => this.WithAttribute(Attribute.Src(value));

        public HtmlTrackElement WithSrcLang(string value) => this.WithAttribute(Attribute.SrcLang(value));
    }
}
