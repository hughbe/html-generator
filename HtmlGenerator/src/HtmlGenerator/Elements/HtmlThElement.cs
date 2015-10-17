namespace HtmlGenerator
{
    public class HtmlThElement : HtmlElement 
    {
        public HtmlThElement() : base("th", false) 
        {    
        }

		public HtmlThElement WithColSpan(string value) => (HtmlThElement)WithAttribute(Attribute.ColSpan(value));

		public HtmlThElement WithHeaders(string value) => (HtmlThElement)WithAttribute(Attribute.Headers(value));

		public HtmlThElement WithRowSpan(string value) => (HtmlThElement)WithAttribute(Attribute.RowSpan(value));

		public HtmlThElement WithScope(string value) => (HtmlThElement)WithAttribute(Attribute.Scope(value));

		public HtmlThElement WithAccessKey(string value) => (HtmlThElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlThElement WithClass(string value) => (HtmlThElement)WithAttribute(Attribute.Class(value));

		public HtmlThElement WithContentEditable(string value) => (HtmlThElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlThElement WithContextMenu(string value) => (HtmlThElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlThElement WithDir(string value) => (HtmlThElement)WithAttribute(Attribute.Dir(value));

		public HtmlThElement WithHidden(string value) => (HtmlThElement)WithAttribute(Attribute.Hidden(value));

		public HtmlThElement WithId(string value) => (HtmlThElement)WithAttribute(Attribute.Id(value));

		public HtmlThElement WithLang(string value) => (HtmlThElement)WithAttribute(Attribute.Lang(value));

		public HtmlThElement WithSpellCheck(string value) => (HtmlThElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlThElement WithStyle(string value) => (HtmlThElement)WithAttribute(Attribute.Style(value));

		public HtmlThElement WithTabIndex(string value) => (HtmlThElement)WithAttribute(Attribute.TabIndex(value));
    }
}
