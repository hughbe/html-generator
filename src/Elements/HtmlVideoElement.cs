namespace HtmlGenerator.Elements
{
    public class HtmlVideoElement : HtmlElement
    {
        public HtmlVideoElement() : base("video") { }

        public HtmlVideoElement WithAutoPlay(string value) => this.WithAttribute(Attribute.AutoPlay(value));

        public HtmlVideoElement WithControls() => this.WithAttribute(Attribute.Controls);

        public HtmlVideoElement WithCrossOrigin(string value) => this.WithAttribute(Attribute.CrossOrigin(value));

        public HtmlVideoElement WithHeight(string value) => this.WithAttribute(Attribute.Height(value));

        public HtmlVideoElement WithLoop(string value) => this.WithAttribute(Attribute.Loop(value));

        public HtmlVideoElement WithMuted(string value) => this.WithAttribute(Attribute.Muted(value));

        public HtmlVideoElement WithPreload(string value) => this.WithAttribute(Attribute.Preload(value));

        public HtmlVideoElement WithSrc(string value) => this.WithAttribute(Attribute.Src(value));

        public HtmlVideoElement WithWidth(string value) => this.WithAttribute(Attribute.Width(value));
    }
}
