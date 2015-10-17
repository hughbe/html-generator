namespace HtmlGenerator
{
    public class HtmlTrackElement : HtmlElement 
    {
        internal HtmlTrackElement() : base("track", true) 
        {    
        }

		public HtmlTrackElement WithKindAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.Kind(value));

		public HtmlTrackElement WithDefaultAttribute() => (HtmlTrackElement)WithAttribute(Attribute.Default);

		public HtmlTrackElement WithLabelAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.Label(value));

		public HtmlTrackElement WithSrcAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.Src(value));

		public HtmlTrackElement WithSrcLangAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.SrcLang(value));
    }
}
