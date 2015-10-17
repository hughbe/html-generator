namespace HtmlGenerator
{
    public class HtmlImgElement : HtmlElement 
    {
        internal HtmlImgElement() : base("img", true) 
        {    
        }

		public HtmlImgElement WithAltAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Alt(value));

		public HtmlImgElement WithCrossOriginAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.CrossOrigin(value));

		public HtmlImgElement WithHeightAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Height(value));

		public HtmlImgElement WithIsMapAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.IsMap(value));

		public HtmlImgElement WithLongDescAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.LongDesc(value));

		public HtmlImgElement WithSizesAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Sizes(value));

		public HtmlImgElement WithSrcAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Src(value));

		public HtmlImgElement WithSrcSetAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.SrcSet(value));

		public HtmlImgElement WithWidthAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Width(value));

		public HtmlImgElement WithUseMapAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.UseMap(value));

		public HtmlImgElement WithAccessKey(string value) => (HtmlImgElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlImgElement WithClass(string value) => (HtmlImgElement)WithAttribute(Attribute.Class(value));

		public HtmlImgElement WithContentEditable(string value) => (HtmlImgElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlImgElement WithContextMenuAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlImgElement WithDir(string value) => (HtmlImgElement)WithAttribute(Attribute.Dir(value));

		public HtmlImgElement WithHidden(string value) => (HtmlImgElement)WithAttribute(Attribute.Hidden(value));

		public HtmlImgElement WithId(string value) => (HtmlImgElement)WithAttribute(Attribute.Id(value));

		public HtmlImgElement WithLang(string value) => (HtmlImgElement)WithAttribute(Attribute.Lang(value));

		public HtmlImgElement WithSpellCheck(string value) => (HtmlImgElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlImgElement WithStyleAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Style(value));

		public HtmlImgElement WithTabIndex(string value) => (HtmlImgElement)WithAttribute(Attribute.TabIndex(value));
    }
}
