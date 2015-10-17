namespace HtmlGenerator
{
    public class HtmlH4Element : HtmlElement 
    {
        internal HtmlH4Element() : base("h4", false) 
        {    
        }

		public HtmlH4Element WithAccessKey(string value) => (HtmlH4Element)WithAttribute(Attribute.AccessKey(value));

		public HtmlH4Element WithClass(string value) => (HtmlH4Element)WithAttribute(Attribute.Class(value));

		public HtmlH4Element WithContentEditable(string value) => (HtmlH4Element)WithAttribute(Attribute.ContentEditable(value));

		public HtmlH4Element WithContextMenuAttribute(string value) => (HtmlH4Element)WithAttribute(Attribute.ContextMenu(value));

		public HtmlH4Element WithDir(string value) => (HtmlH4Element)WithAttribute(Attribute.Dir(value));

		public HtmlH4Element WithHidden(string value) => (HtmlH4Element)WithAttribute(Attribute.Hidden(value));

		public HtmlH4Element WithId(string value) => (HtmlH4Element)WithAttribute(Attribute.Id(value));

		public HtmlH4Element WithLang(string value) => (HtmlH4Element)WithAttribute(Attribute.Lang(value));

		public HtmlH4Element WithSpellCheck(string value) => (HtmlH4Element)WithAttribute(Attribute.SpellCheck(value));

		public HtmlH4Element WithStyleAttribute(string value) => (HtmlH4Element)WithAttribute(Attribute.Style(value));

		public HtmlH4Element WithTabIndex(string value) => (HtmlH4Element)WithAttribute(Attribute.TabIndex(value));
    }
}
