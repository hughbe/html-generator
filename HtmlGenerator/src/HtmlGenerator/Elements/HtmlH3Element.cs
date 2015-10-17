namespace HtmlGenerator
{
    public class HtmlH3Element : HtmlElement 
    {
        public HtmlH3Element() : base("h3", false) 
        {    
        }

		public HtmlH3Element WithAccessKey(string value) => (HtmlH3Element)WithAttribute(Attribute.AccessKey(value));

		public HtmlH3Element WithClass(string value) => (HtmlH3Element)WithAttribute(Attribute.Class(value));

		public HtmlH3Element WithContentEditable(string value) => (HtmlH3Element)WithAttribute(Attribute.ContentEditable(value));

		public HtmlH3Element WithContextMenu(string value) => (HtmlH3Element)WithAttribute(Attribute.ContextMenu(value));

		public HtmlH3Element WithDir(string value) => (HtmlH3Element)WithAttribute(Attribute.Dir(value));

		public HtmlH3Element WithHidden(string value) => (HtmlH3Element)WithAttribute(Attribute.Hidden(value));

		public HtmlH3Element WithId(string value) => (HtmlH3Element)WithAttribute(Attribute.Id(value));

		public HtmlH3Element WithLang(string value) => (HtmlH3Element)WithAttribute(Attribute.Lang(value));

		public HtmlH3Element WithSpellCheck(string value) => (HtmlH3Element)WithAttribute(Attribute.SpellCheck(value));

		public HtmlH3Element WithStyle(string value) => (HtmlH3Element)WithAttribute(Attribute.Style(value));

		public HtmlH3Element WithTabIndex(string value) => (HtmlH3Element)WithAttribute(Attribute.TabIndex(value));
    }
}
