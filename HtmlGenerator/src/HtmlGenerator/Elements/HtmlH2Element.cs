namespace HtmlGenerator
{
    public class HtmlH2Element : HtmlElement 
    {
        internal HtmlH2Element() : base("h2", false) 
        {    
        }

		public HtmlH2Element WithAccessKey(string value) => (HtmlH2Element)WithAttribute(Attribute.AccessKey(value));

		public HtmlH2Element WithClass(string value) => (HtmlH2Element)WithAttribute(Attribute.Class(value));

		public HtmlH2Element WithContentEditable(string value) => (HtmlH2Element)WithAttribute(Attribute.ContentEditable(value));

		public HtmlH2Element WithContextMenuAttribute(string value) => (HtmlH2Element)WithAttribute(Attribute.ContextMenu(value));

		public HtmlH2Element WithDir(string value) => (HtmlH2Element)WithAttribute(Attribute.Dir(value));

		public HtmlH2Element WithHidden(string value) => (HtmlH2Element)WithAttribute(Attribute.Hidden(value));

		public HtmlH2Element WithId(string value) => (HtmlH2Element)WithAttribute(Attribute.Id(value));

		public HtmlH2Element WithLang(string value) => (HtmlH2Element)WithAttribute(Attribute.Lang(value));

		public HtmlH2Element WithSpellCheck(string value) => (HtmlH2Element)WithAttribute(Attribute.SpellCheck(value));

		public HtmlH2Element WithStyleAttribute(string value) => (HtmlH2Element)WithAttribute(Attribute.Style(value));

		public HtmlH2Element WithTabIndex(string value) => (HtmlH2Element)WithAttribute(Attribute.TabIndex(value));
    }
}
