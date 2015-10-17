namespace HtmlGenerator
{
    public class HtmlTrackElement : HtmlElement 
    {
        internal HtmlTrackElement() : base("track", true) 
        {    
        }

		public HtmlTrackElement WithDefault() => (HtmlTrackElement)WithAttribute(Attribute.Default);

		public HtmlTrackElement WithKind(string value) => (HtmlTrackElement)WithAttribute(Attribute.Kind(value));

		public HtmlTrackElement WithLabel(string value) => (HtmlTrackElement)WithAttribute(Attribute.Label(value));

		public HtmlTrackElement WithSrc(string value) => (HtmlTrackElement)WithAttribute(Attribute.Src(value));

		public HtmlTrackElement WithSrcLang(string value) => (HtmlTrackElement)WithAttribute(Attribute.SrcLang(value));

		public HtmlTrackElement WithAccessKey(string value) => (HtmlTrackElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTrackElement WithClass(string value) => (HtmlTrackElement)WithAttribute(Attribute.Class(value));

		public HtmlTrackElement WithContentEditable(string value) => (HtmlTrackElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTrackElement WithContextMenu(string value) => (HtmlTrackElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTrackElement WithDir(string value) => (HtmlTrackElement)WithAttribute(Attribute.Dir(value));

		public HtmlTrackElement WithHidden(string value) => (HtmlTrackElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTrackElement WithId(string value) => (HtmlTrackElement)WithAttribute(Attribute.Id(value));

		public HtmlTrackElement WithLang(string value) => (HtmlTrackElement)WithAttribute(Attribute.Lang(value));

		public HtmlTrackElement WithSpellCheck(string value) => (HtmlTrackElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTrackElement WithStyle(string value) => (HtmlTrackElement)WithAttribute(Attribute.Style(value));

		public HtmlTrackElement WithTabIndex(string value) => (HtmlTrackElement)WithAttribute(Attribute.TabIndex(value));
    }
}
