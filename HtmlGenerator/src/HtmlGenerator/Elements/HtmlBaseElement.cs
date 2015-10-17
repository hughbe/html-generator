namespace HtmlGenerator
{
    public class HtmlBaseElement : HtmlElement 
    {
        internal HtmlBaseElement() : base("base", true) 
        {    
        }

		public HtmlBaseElement WithHrefAttribute(string value) => (HtmlBaseElement)WithAttribute(Attribute.Href(value));

		public HtmlBaseElement WithTargetAttribute(string value) => (HtmlBaseElement)WithAttribute(Attribute.Target(value));

		public HtmlBaseElement WithAccessKey(string value) => (HtmlBaseElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlBaseElement WithClass(string value) => (HtmlBaseElement)WithAttribute(Attribute.Class(value));

		public HtmlBaseElement WithContentEditable(string value) => (HtmlBaseElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlBaseElement WithContextMenuAttribute(string value) => (HtmlBaseElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlBaseElement WithDir(string value) => (HtmlBaseElement)WithAttribute(Attribute.Dir(value));

		public HtmlBaseElement WithHidden(string value) => (HtmlBaseElement)WithAttribute(Attribute.Hidden(value));

		public HtmlBaseElement WithId(string value) => (HtmlBaseElement)WithAttribute(Attribute.Id(value));

		public HtmlBaseElement WithLang(string value) => (HtmlBaseElement)WithAttribute(Attribute.Lang(value));

		public HtmlBaseElement WithSpellCheck(string value) => (HtmlBaseElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlBaseElement WithStyleAttribute(string value) => (HtmlBaseElement)WithAttribute(Attribute.Style(value));

		public HtmlBaseElement WithTabIndex(string value) => (HtmlBaseElement)WithAttribute(Attribute.TabIndex(value));
    }
}
