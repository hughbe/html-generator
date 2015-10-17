namespace HtmlGenerator
{
    public class HtmlMarkElement : HtmlElement 
    {
        internal HtmlMarkElement() : base("mark", false) 
        {    
        }

		public HtmlMarkElement WithAccessKey(string value) => (HtmlMarkElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMarkElement WithClass(string value) => (HtmlMarkElement)WithAttribute(Attribute.Class(value));

		public HtmlMarkElement WithContentEditable(string value) => (HtmlMarkElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMarkElement WithContextMenuAttribute(string value) => (HtmlMarkElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMarkElement WithDir(string value) => (HtmlMarkElement)WithAttribute(Attribute.Dir(value));

		public HtmlMarkElement WithHidden(string value) => (HtmlMarkElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMarkElement WithId(string value) => (HtmlMarkElement)WithAttribute(Attribute.Id(value));

		public HtmlMarkElement WithLang(string value) => (HtmlMarkElement)WithAttribute(Attribute.Lang(value));

		public HtmlMarkElement WithSpellCheck(string value) => (HtmlMarkElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMarkElement WithStyleAttribute(string value) => (HtmlMarkElement)WithAttribute(Attribute.Style(value));

		public HtmlMarkElement WithTabIndex(string value) => (HtmlMarkElement)WithAttribute(Attribute.TabIndex(value));
    }
}
