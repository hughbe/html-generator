namespace HtmlGenerator
{
    public class HtmlUElement : HtmlElement 
    {
        internal HtmlUElement() : base("u", false) 
        {    
        }

		public HtmlUElement WithAccessKey(string value) => (HtmlUElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlUElement WithClass(string value) => (HtmlUElement)WithAttribute(Attribute.Class(value));

		public HtmlUElement WithContentEditable(string value) => (HtmlUElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlUElement WithContextMenuAttribute(string value) => (HtmlUElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlUElement WithDir(string value) => (HtmlUElement)WithAttribute(Attribute.Dir(value));

		public HtmlUElement WithHidden(string value) => (HtmlUElement)WithAttribute(Attribute.Hidden(value));

		public HtmlUElement WithId(string value) => (HtmlUElement)WithAttribute(Attribute.Id(value));

		public HtmlUElement WithLang(string value) => (HtmlUElement)WithAttribute(Attribute.Lang(value));

		public HtmlUElement WithSpellCheck(string value) => (HtmlUElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlUElement WithStyleAttribute(string value) => (HtmlUElement)WithAttribute(Attribute.Style(value));

		public HtmlUElement WithTabIndex(string value) => (HtmlUElement)WithAttribute(Attribute.TabIndex(value));
    }
}
