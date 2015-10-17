namespace HtmlGenerator
{
    public class HtmlDtElement : HtmlElement 
    {
        internal HtmlDtElement() : base("dt", false) 
        {    
        }

		public HtmlDtElement WithAccessKey(string value) => (HtmlDtElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDtElement WithClass(string value) => (HtmlDtElement)WithAttribute(Attribute.Class(value));

		public HtmlDtElement WithContentEditable(string value) => (HtmlDtElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDtElement WithContextMenuAttribute(string value) => (HtmlDtElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDtElement WithDir(string value) => (HtmlDtElement)WithAttribute(Attribute.Dir(value));

		public HtmlDtElement WithHidden(string value) => (HtmlDtElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDtElement WithId(string value) => (HtmlDtElement)WithAttribute(Attribute.Id(value));

		public HtmlDtElement WithLang(string value) => (HtmlDtElement)WithAttribute(Attribute.Lang(value));

		public HtmlDtElement WithSpellCheck(string value) => (HtmlDtElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDtElement WithStyleAttribute(string value) => (HtmlDtElement)WithAttribute(Attribute.Style(value));

		public HtmlDtElement WithTabIndex(string value) => (HtmlDtElement)WithAttribute(Attribute.TabIndex(value));
    }
}
