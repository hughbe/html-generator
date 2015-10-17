namespace HtmlGenerator
{
    public class HtmlKbdElement : HtmlElement 
    {
        internal HtmlKbdElement() : base("kbd", false) 
        {    
        }

		public HtmlKbdElement WithAccessKey(string value) => (HtmlKbdElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlKbdElement WithClass(string value) => (HtmlKbdElement)WithAttribute(Attribute.Class(value));

		public HtmlKbdElement WithContentEditable(string value) => (HtmlKbdElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlKbdElement WithContextMenuAttribute(string value) => (HtmlKbdElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlKbdElement WithDir(string value) => (HtmlKbdElement)WithAttribute(Attribute.Dir(value));

		public HtmlKbdElement WithHidden(string value) => (HtmlKbdElement)WithAttribute(Attribute.Hidden(value));

		public HtmlKbdElement WithId(string value) => (HtmlKbdElement)WithAttribute(Attribute.Id(value));

		public HtmlKbdElement WithLang(string value) => (HtmlKbdElement)WithAttribute(Attribute.Lang(value));

		public HtmlKbdElement WithSpellCheck(string value) => (HtmlKbdElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlKbdElement WithStyleAttribute(string value) => (HtmlKbdElement)WithAttribute(Attribute.Style(value));

		public HtmlKbdElement WithTabIndex(string value) => (HtmlKbdElement)WithAttribute(Attribute.TabIndex(value));
    }
}
