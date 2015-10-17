namespace HtmlGenerator
{
    public class HtmlVideoElement : HtmlElement 
    {
        internal HtmlVideoElement() : base("video", false) 
        {    
        }

		public HtmlVideoElement WithAutoPlayAttribute(string value) => (HtmlVideoElement)WithAttribute(Attribute.AutoPlay(value));

		public HtmlVideoElement WithControlsAttribute() => (HtmlVideoElement)WithAttribute(Attribute.Controls);

		public HtmlVideoElement WithCrossOriginAttribute(string value) => (HtmlVideoElement)WithAttribute(Attribute.CrossOrigin(value));

		public HtmlVideoElement WithHeightAttribute(string value) => (HtmlVideoElement)WithAttribute(Attribute.Height(value));

		public HtmlVideoElement WithLoopAttribute(string value) => (HtmlVideoElement)WithAttribute(Attribute.Loop(value));

		public HtmlVideoElement WithMutedAttribute(string value) => (HtmlVideoElement)WithAttribute(Attribute.Muted(value));

		public HtmlVideoElement WithPreloadAttribute(string value) => (HtmlVideoElement)WithAttribute(Attribute.Preload(value));

		public HtmlVideoElement WithSrcAttribute(string value) => (HtmlVideoElement)WithAttribute(Attribute.Src(value));

		public HtmlVideoElement WithWidthAttribute(string value) => (HtmlVideoElement)WithAttribute(Attribute.Width(value));
    }
}
