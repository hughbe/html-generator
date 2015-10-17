namespace HtmlGenerator
{
    public class HtmlHtmlElement : HtmlElement 
    {
        public HtmlHtmlElement() : base("html", false) 
        {    
        }

		public HtmlHtmlElement WithXmls(string value) => (HtmlHtmlElement)WithAttribute(Attribute.Xmls(value));

		public HtmlHtmlElement WithAccessKey(string value) => (HtmlHtmlElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlHtmlElement WithClass(string value) => (HtmlHtmlElement)WithAttribute(Attribute.Class(value));

		public HtmlHtmlElement WithContentEditable(string value) => (HtmlHtmlElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlHtmlElement WithContextMenu(string value) => (HtmlHtmlElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlHtmlElement WithDir(string value) => (HtmlHtmlElement)WithAttribute(Attribute.Dir(value));

		public HtmlHtmlElement WithHidden(string value) => (HtmlHtmlElement)WithAttribute(Attribute.Hidden(value));

		public HtmlHtmlElement WithId(string value) => (HtmlHtmlElement)WithAttribute(Attribute.Id(value));

		public HtmlHtmlElement WithLang(string value) => (HtmlHtmlElement)WithAttribute(Attribute.Lang(value));

		public HtmlHtmlElement WithSpellCheck(string value) => (HtmlHtmlElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlHtmlElement WithStyle(string value) => (HtmlHtmlElement)WithAttribute(Attribute.Style(value));

		public HtmlHtmlElement WithTabIndex(string value) => (HtmlHtmlElement)WithAttribute(Attribute.TabIndex(value));
    }
}
