namespace HtmlGenerator
{
    public class HtmlFooterElement : HtmlElement 
    {
        public HtmlFooterElement() : base("footer", false) 
        {    
        }

		public HtmlFooterElement WithAccessKey(string value) => (HtmlFooterElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlFooterElement WithClass(string value) => (HtmlFooterElement)WithAttribute(Attribute.Class(value));

		public HtmlFooterElement WithContentEditable(string value) => (HtmlFooterElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlFooterElement WithContextMenu(string value) => (HtmlFooterElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlFooterElement WithDir(string value) => (HtmlFooterElement)WithAttribute(Attribute.Dir(value));

		public HtmlFooterElement WithHidden(string value) => (HtmlFooterElement)WithAttribute(Attribute.Hidden(value));

		public HtmlFooterElement WithId(string value) => (HtmlFooterElement)WithAttribute(Attribute.Id(value));

		public HtmlFooterElement WithLang(string value) => (HtmlFooterElement)WithAttribute(Attribute.Lang(value));

		public HtmlFooterElement WithSpellCheck(string value) => (HtmlFooterElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlFooterElement WithStyle(string value) => (HtmlFooterElement)WithAttribute(Attribute.Style(value));

		public HtmlFooterElement WithTabIndex(string value) => (HtmlFooterElement)WithAttribute(Attribute.TabIndex(value));
    }
}
