namespace HtmlGenerator
{
    public class HtmlSubElement : HtmlElement 
    {
        internal HtmlSubElement() : base("sub", false) 
        {    
        }

		public HtmlSubElement WithAccessKey(string value) => (HtmlSubElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSubElement WithClass(string value) => (HtmlSubElement)WithAttribute(Attribute.Class(value));

		public HtmlSubElement WithContentEditable(string value) => (HtmlSubElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSubElement WithContextMenuAttribute(string value) => (HtmlSubElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSubElement WithDir(string value) => (HtmlSubElement)WithAttribute(Attribute.Dir(value));

		public HtmlSubElement WithHidden(string value) => (HtmlSubElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSubElement WithId(string value) => (HtmlSubElement)WithAttribute(Attribute.Id(value));

		public HtmlSubElement WithLang(string value) => (HtmlSubElement)WithAttribute(Attribute.Lang(value));

		public HtmlSubElement WithSpellCheck(string value) => (HtmlSubElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSubElement WithStyleAttribute(string value) => (HtmlSubElement)WithAttribute(Attribute.Style(value));

		public HtmlSubElement WithTabIndex(string value) => (HtmlSubElement)WithAttribute(Attribute.TabIndex(value));
    }
}
