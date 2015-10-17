namespace HtmlGenerator
{
    public class HtmlSourceElement : HtmlElement 
    {
        internal HtmlSourceElement() : base("source", true) 
        {    
        }

		public HtmlSourceElement WithSrcAttribute(string value) => (HtmlSourceElement)WithAttribute(Attribute.Src(value));

		public HtmlSourceElement WithTypeAttribute(string value) => (HtmlSourceElement)WithAttribute(Attribute.Type(value));

		public HtmlSourceElement WithAccessKey(string value) => (HtmlSourceElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSourceElement WithClass(string value) => (HtmlSourceElement)WithAttribute(Attribute.Class(value));

		public HtmlSourceElement WithContentEditable(string value) => (HtmlSourceElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSourceElement WithContextMenuAttribute(string value) => (HtmlSourceElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSourceElement WithDir(string value) => (HtmlSourceElement)WithAttribute(Attribute.Dir(value));

		public HtmlSourceElement WithHidden(string value) => (HtmlSourceElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSourceElement WithId(string value) => (HtmlSourceElement)WithAttribute(Attribute.Id(value));

		public HtmlSourceElement WithLang(string value) => (HtmlSourceElement)WithAttribute(Attribute.Lang(value));

		public HtmlSourceElement WithSpellCheck(string value) => (HtmlSourceElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSourceElement WithStyleAttribute(string value) => (HtmlSourceElement)WithAttribute(Attribute.Style(value));

		public HtmlSourceElement WithTabIndex(string value) => (HtmlSourceElement)WithAttribute(Attribute.TabIndex(value));
    }
}
