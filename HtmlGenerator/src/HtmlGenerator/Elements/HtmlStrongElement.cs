namespace HtmlGenerator
{
    public class HtmlStrongElement : HtmlElement 
    {
        internal HtmlStrongElement() : base("strong", false) 
        {    
        }

		public HtmlStrongElement WithAccessKey(string value) => (HtmlStrongElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlStrongElement WithClass(string value) => (HtmlStrongElement)WithAttribute(Attribute.Class(value));

		public HtmlStrongElement WithContentEditable(string value) => (HtmlStrongElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlStrongElement WithContextMenuAttribute(string value) => (HtmlStrongElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlStrongElement WithDir(string value) => (HtmlStrongElement)WithAttribute(Attribute.Dir(value));

		public HtmlStrongElement WithHidden(string value) => (HtmlStrongElement)WithAttribute(Attribute.Hidden(value));

		public HtmlStrongElement WithId(string value) => (HtmlStrongElement)WithAttribute(Attribute.Id(value));

		public HtmlStrongElement WithLang(string value) => (HtmlStrongElement)WithAttribute(Attribute.Lang(value));

		public HtmlStrongElement WithSpellCheck(string value) => (HtmlStrongElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlStrongElement WithStyleAttribute(string value) => (HtmlStrongElement)WithAttribute(Attribute.Style(value));

		public HtmlStrongElement WithTabIndex(string value) => (HtmlStrongElement)WithAttribute(Attribute.TabIndex(value));
    }
}
