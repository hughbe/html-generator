namespace HtmlGenerator
{
    public class HtmlImgElement : HtmlElement 
    {
        public HtmlImgElement() : base("img", true) 
        {    
        }

		public HtmlImgElement WithAlt(string value) => (HtmlImgElement)WithAttribute(Attribute.Alt(value));

		public HtmlImgElement WithCrossOrigin(string value) => (HtmlImgElement)WithAttribute(Attribute.CrossOrigin(value));

		public HtmlImgElement WithHeight(string value) => (HtmlImgElement)WithAttribute(Attribute.Height(value));

		public HtmlImgElement WithIsMap(string value) => (HtmlImgElement)WithAttribute(Attribute.IsMap(value));

		public HtmlImgElement WithLongDesc(string value) => (HtmlImgElement)WithAttribute(Attribute.LongDesc(value));

		public HtmlImgElement WithSizes(string value) => (HtmlImgElement)WithAttribute(Attribute.Sizes(value));

		public HtmlImgElement WithSrc(string value) => (HtmlImgElement)WithAttribute(Attribute.Src(value));

		public HtmlImgElement WithSrcSet(string value) => (HtmlImgElement)WithAttribute(Attribute.SrcSet(value));

		public HtmlImgElement WithWidth(string value) => (HtmlImgElement)WithAttribute(Attribute.Width(value));

		public HtmlImgElement WithUseMap(string value) => (HtmlImgElement)WithAttribute(Attribute.UseMap(value));

		public HtmlImgElement WithAccessKey(string value) => (HtmlImgElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlImgElement WithClass(string value) => (HtmlImgElement)WithAttribute(Attribute.Class(value));

		public HtmlImgElement WithContentEditable(string value) => (HtmlImgElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlImgElement WithContextMenu(string value) => (HtmlImgElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlImgElement WithDir(string value) => (HtmlImgElement)WithAttribute(Attribute.Dir(value));

		public HtmlImgElement WithHidden(string value) => (HtmlImgElement)WithAttribute(Attribute.Hidden(value));

		public HtmlImgElement WithId(string value) => (HtmlImgElement)WithAttribute(Attribute.Id(value));

		public HtmlImgElement WithLang(string value) => (HtmlImgElement)WithAttribute(Attribute.Lang(value));

		public HtmlImgElement WithSpellCheck(string value) => (HtmlImgElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlImgElement WithStyle(string value) => (HtmlImgElement)WithAttribute(Attribute.Style(value));

		public HtmlImgElement WithTabIndex(string value) => (HtmlImgElement)WithAttribute(Attribute.TabIndex(value));
    }
}
