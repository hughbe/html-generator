namespace HtmlGenerator
{
    public class HtmlBaseElement : HtmlElement 
    {
        public HtmlBaseElement() : base("base", true) 
        {    
        }

		public HtmlBaseElement WithHref(string value) => (HtmlBaseElement)WithAttribute(Attribute.Href(value));

		public HtmlBaseElement WithTarget(string value) => (HtmlBaseElement)WithAttribute(Attribute.Target(value));

		public HtmlBaseElement WithAccessKey(string value) => (HtmlBaseElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlBaseElement WithClass(string value) => (HtmlBaseElement)WithAttribute(Attribute.Class(value));

		public HtmlBaseElement WithContentEditable(string value) => (HtmlBaseElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlBaseElement WithContextMenu(string value) => (HtmlBaseElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlBaseElement WithDir(string value) => (HtmlBaseElement)WithAttribute(Attribute.Dir(value));

		public HtmlBaseElement WithHidden(string value) => (HtmlBaseElement)WithAttribute(Attribute.Hidden(value));

		public HtmlBaseElement WithId(string value) => (HtmlBaseElement)WithAttribute(Attribute.Id(value));

		public HtmlBaseElement WithLang(string value) => (HtmlBaseElement)WithAttribute(Attribute.Lang(value));

		public HtmlBaseElement WithSpellCheck(string value) => (HtmlBaseElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlBaseElement WithStyle(string value) => (HtmlBaseElement)WithAttribute(Attribute.Style(value));

		public HtmlBaseElement WithTabIndex(string value) => (HtmlBaseElement)WithAttribute(Attribute.TabIndex(value));
    }
}
