namespace HtmlGenerator
{
    public class HtmlH1Element : HtmlElement 
    {
        public HtmlH1Element() : base("h1", false) 
        {    
        }

		public HtmlH1Element WithAccessKey(string value) => (HtmlH1Element)WithAttribute(Attribute.AccessKey(value));

		public HtmlH1Element WithClass(string value) => (HtmlH1Element)WithAttribute(Attribute.Class(value));

		public HtmlH1Element WithContentEditable(string value) => (HtmlH1Element)WithAttribute(Attribute.ContentEditable(value));

		public HtmlH1Element WithContextMenu(string value) => (HtmlH1Element)WithAttribute(Attribute.ContextMenu(value));

		public HtmlH1Element WithDir(string value) => (HtmlH1Element)WithAttribute(Attribute.Dir(value));

		public HtmlH1Element WithHidden(string value) => (HtmlH1Element)WithAttribute(Attribute.Hidden(value));

		public HtmlH1Element WithId(string value) => (HtmlH1Element)WithAttribute(Attribute.Id(value));

		public HtmlH1Element WithLang(string value) => (HtmlH1Element)WithAttribute(Attribute.Lang(value));

		public HtmlH1Element WithSpellCheck(string value) => (HtmlH1Element)WithAttribute(Attribute.SpellCheck(value));

		public HtmlH1Element WithStyle(string value) => (HtmlH1Element)WithAttribute(Attribute.Style(value));

		public HtmlH1Element WithTabIndex(string value) => (HtmlH1Element)WithAttribute(Attribute.TabIndex(value));
    }
}
