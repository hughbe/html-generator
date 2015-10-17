namespace HtmlGenerator
{
    public class HtmlH6Element : HtmlElement 
    {
        internal HtmlH6Element() : base("h6", false) 
        {    
        }

		public HtmlH6Element WithAccessKey(string value) => (HtmlH6Element)WithAttribute(Attribute.AccessKey(value));

		public HtmlH6Element WithClass(string value) => (HtmlH6Element)WithAttribute(Attribute.Class(value));

		public HtmlH6Element WithContentEditable(string value) => (HtmlH6Element)WithAttribute(Attribute.ContentEditable(value));

		public HtmlH6Element WithContextMenu(string value) => (HtmlH6Element)WithAttribute(Attribute.ContextMenu(value));

		public HtmlH6Element WithDir(string value) => (HtmlH6Element)WithAttribute(Attribute.Dir(value));

		public HtmlH6Element WithHidden(string value) => (HtmlH6Element)WithAttribute(Attribute.Hidden(value));

		public HtmlH6Element WithId(string value) => (HtmlH6Element)WithAttribute(Attribute.Id(value));

		public HtmlH6Element WithLang(string value) => (HtmlH6Element)WithAttribute(Attribute.Lang(value));

		public HtmlH6Element WithSpellCheck(string value) => (HtmlH6Element)WithAttribute(Attribute.SpellCheck(value));

		public HtmlH6Element WithStyle(string value) => (HtmlH6Element)WithAttribute(Attribute.Style(value));

		public HtmlH6Element WithTabIndex(string value) => (HtmlH6Element)WithAttribute(Attribute.TabIndex(value));
    }
}
