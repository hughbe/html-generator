namespace HtmlGenerator
{
    public class HtmlHeaderElement : HtmlElement 
    {
        internal HtmlHeaderElement() : base("header", false) 
        {    
        }

		public HtmlHeaderElement WithAccessKey(string value) => (HtmlHeaderElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlHeaderElement WithClass(string value) => (HtmlHeaderElement)WithAttribute(Attribute.Class(value));

		public HtmlHeaderElement WithContentEditable(string value) => (HtmlHeaderElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlHeaderElement WithContextMenuAttribute(string value) => (HtmlHeaderElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlHeaderElement WithDir(string value) => (HtmlHeaderElement)WithAttribute(Attribute.Dir(value));

		public HtmlHeaderElement WithHidden(string value) => (HtmlHeaderElement)WithAttribute(Attribute.Hidden(value));

		public HtmlHeaderElement WithId(string value) => (HtmlHeaderElement)WithAttribute(Attribute.Id(value));

		public HtmlHeaderElement WithLang(string value) => (HtmlHeaderElement)WithAttribute(Attribute.Lang(value));

		public HtmlHeaderElement WithSpellCheck(string value) => (HtmlHeaderElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlHeaderElement WithStyleAttribute(string value) => (HtmlHeaderElement)WithAttribute(Attribute.Style(value));

		public HtmlHeaderElement WithTabIndex(string value) => (HtmlHeaderElement)WithAttribute(Attribute.TabIndex(value));
    }
}
