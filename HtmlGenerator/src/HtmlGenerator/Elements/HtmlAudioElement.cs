namespace HtmlGenerator
{
    public class HtmlAudioElement : HtmlElement 
    {
        internal HtmlAudioElement() : base("audio", false) 
        {    
        }

		public HtmlAudioElement WithAutoPlayAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.AutoPlay(value));

		public HtmlAudioElement WithControlsAttribute() => (HtmlAudioElement)WithAttribute(Attribute.Controls);

		public HtmlAudioElement WithLoopAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Loop(value));

		public HtmlAudioElement WithMutedAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Muted(value));

		public HtmlAudioElement WithPreloadAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Preload(value));

		public HtmlAudioElement WithSrcAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Src(value));

		public HtmlAudioElement WithVolumeAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Volume(value));
    }
}
