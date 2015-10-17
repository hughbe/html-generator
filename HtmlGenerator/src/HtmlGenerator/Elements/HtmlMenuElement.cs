namespace HtmlGenerator
{
    public class HtmlMenuElement : HtmlElement 
    {
        internal HtmlMenuElement() : base("menu", false) 
        {    
        }

		public HtmlMenuElement WithLabelAttribute(string value) => (HtmlMenuElement)WithAttribute(Attribute.Label(value));

		public HtmlMenuElement WithTypeAttribute(string value) => (HtmlMenuElement)WithAttribute(Attribute.Type(value));

		public HtmlMenuElement WithAccessKey(string value) => (HtmlMenuElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMenuElement WithClass(string value) => (HtmlMenuElement)WithAttribute(Attribute.Class(value));

		public HtmlMenuElement WithContentEditable(string value) => (HtmlMenuElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMenuElement WithContextMenuAttribute(string value) => (HtmlMenuElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMenuElement WithDir(string value) => (HtmlMenuElement)WithAttribute(Attribute.Dir(value));

		public HtmlMenuElement WithHidden(string value) => (HtmlMenuElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMenuElement WithId(string value) => (HtmlMenuElement)WithAttribute(Attribute.Id(value));

		public HtmlMenuElement WithLang(string value) => (HtmlMenuElement)WithAttribute(Attribute.Lang(value));

		public HtmlMenuElement WithSpellCheck(string value) => (HtmlMenuElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMenuElement WithStyleAttribute(string value) => (HtmlMenuElement)WithAttribute(Attribute.Style(value));

		public HtmlMenuElement WithTabIndex(string value) => (HtmlMenuElement)WithAttribute(Attribute.TabIndex(value));
    }
}
