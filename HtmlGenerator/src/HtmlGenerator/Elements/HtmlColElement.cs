namespace HtmlGenerator
{
    public class HtmlColElement : HtmlElement 
    {
        internal HtmlColElement() : base("col", true) 
        {    
        }

		public HtmlColElement WithSpan(string value) => (HtmlColElement)WithAttribute(Attribute.Span(value));

		public HtmlColElement WithAccessKey(string value) => (HtmlColElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlColElement WithClass(string value) => (HtmlColElement)WithAttribute(Attribute.Class(value));

		public HtmlColElement WithContentEditable(string value) => (HtmlColElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlColElement WithContextMenu(string value) => (HtmlColElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlColElement WithDir(string value) => (HtmlColElement)WithAttribute(Attribute.Dir(value));

		public HtmlColElement WithHidden(string value) => (HtmlColElement)WithAttribute(Attribute.Hidden(value));

		public HtmlColElement WithId(string value) => (HtmlColElement)WithAttribute(Attribute.Id(value));

		public HtmlColElement WithLang(string value) => (HtmlColElement)WithAttribute(Attribute.Lang(value));

		public HtmlColElement WithSpellCheck(string value) => (HtmlColElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlColElement WithStyle(string value) => (HtmlColElement)WithAttribute(Attribute.Style(value));

		public HtmlColElement WithTabIndex(string value) => (HtmlColElement)WithAttribute(Attribute.TabIndex(value));
    }
}
