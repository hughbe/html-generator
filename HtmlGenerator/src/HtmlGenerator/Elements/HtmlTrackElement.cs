namespace HtmlGenerator
{
    public class HtmlTrackElement : HtmlElement 
    {
        internal HtmlTrackElement() : base("track", true) 
        {    
        }

		public HtmlTrackElement WithDefaultAttribute() => (HtmlTrackElement)WithAttribute(Attribute.Default);

		public HtmlTrackElement WithKindAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.Kind(value));

		public HtmlTrackElement WithLabelAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.Label(value));

		public HtmlTrackElement WithSrcAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.Src(value));

		public HtmlTrackElement WithSrcLangAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.SrcLang(value));

		public HtmlTrackElement WithAccessKey(string value) => (HtmlTrackElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTrackElement WithClass(string value) => (HtmlTrackElement)WithAttribute(Attribute.Class(value));

		public HtmlTrackElement WithContentEditable(string value) => (HtmlTrackElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTrackElement WithContextMenuAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTrackElement WithDir(string value) => (HtmlTrackElement)WithAttribute(Attribute.Dir(value));

		public HtmlTrackElement WithHidden(string value) => (HtmlTrackElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTrackElement WithId(string value) => (HtmlTrackElement)WithAttribute(Attribute.Id(value));

		public HtmlTrackElement WithLang(string value) => (HtmlTrackElement)WithAttribute(Attribute.Lang(value));

		public HtmlTrackElement WithSpellCheck(string value) => (HtmlTrackElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTrackElement WithStyleAttribute(string value) => (HtmlTrackElement)WithAttribute(Attribute.Style(value));

		public HtmlTrackElement WithTabIndex(string value) => (HtmlTrackElement)WithAttribute(Attribute.TabIndex(value));
    }
}
