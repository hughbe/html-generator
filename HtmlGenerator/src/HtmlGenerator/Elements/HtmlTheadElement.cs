namespace HtmlGenerator
{
    public class HtmlTheadElement : HtmlElement 
    {
        internal HtmlTheadElement() : base("thead", false) 
        {    
        }

		public HtmlTheadElement WithAccessKey(string value) => (HtmlTheadElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTheadElement WithClass(string value) => (HtmlTheadElement)WithAttribute(Attribute.Class(value));

		public HtmlTheadElement WithContentEditable(string value) => (HtmlTheadElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTheadElement WithContextMenu(string value) => (HtmlTheadElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTheadElement WithDir(string value) => (HtmlTheadElement)WithAttribute(Attribute.Dir(value));

		public HtmlTheadElement WithHidden(string value) => (HtmlTheadElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTheadElement WithId(string value) => (HtmlTheadElement)WithAttribute(Attribute.Id(value));

		public HtmlTheadElement WithLang(string value) => (HtmlTheadElement)WithAttribute(Attribute.Lang(value));

		public HtmlTheadElement WithSpellCheck(string value) => (HtmlTheadElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTheadElement WithStyle(string value) => (HtmlTheadElement)WithAttribute(Attribute.Style(value));

		public HtmlTheadElement WithTabIndex(string value) => (HtmlTheadElement)WithAttribute(Attribute.TabIndex(value));
    }
}
