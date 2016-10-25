namespace HtmlGenerator.Elements
{
    public class HtmlAudioElement : HtmlElement
    {
        public HtmlAudioElement() : base("audio") { }

        public HtmlAudioElement WithAutoPlay(string value) => this.WithAttribute(Attribute.AutoPlay(value));

        public HtmlAudioElement WithControls() => this.WithAttribute(Attribute.Controls);

        public HtmlAudioElement WithLoop(string value) => this.WithAttribute(Attribute.Loop(value));

        public HtmlAudioElement WithMuted(string value) => this.WithAttribute(Attribute.Muted(value));

        public HtmlAudioElement WithPreload(string value) => this.WithAttribute(Attribute.Preload(value));

        public HtmlAudioElement WithSrc(string value) => this.WithAttribute(Attribute.Src(value));

        public HtmlAudioElement WithVolume(string value) => this.WithAttribute(Attribute.Volume(value));
    }
}
