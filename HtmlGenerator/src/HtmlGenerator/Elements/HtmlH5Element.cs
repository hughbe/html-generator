namespace HtmlGenerator
{
    public class HtmlH5Element : HtmlElement 
    {
        public HtmlH5Element() : base("h5", false) 
        {    
        }

		public HtmlH5Element WithAccessKey(string value) => (HtmlH5Element)WithAttribute(Attribute.AccessKey(value));

		public HtmlH5Element WithClass(string value) => (HtmlH5Element)WithAttribute(Attribute.Class(value));

		public HtmlH5Element WithContentEditable(string value) => (HtmlH5Element)WithAttribute(Attribute.ContentEditable(value));

		public HtmlH5Element WithContextMenu(string value) => (HtmlH5Element)WithAttribute(Attribute.ContextMenu(value));

		public HtmlH5Element WithDir(string value) => (HtmlH5Element)WithAttribute(Attribute.Dir(value));

		public HtmlH5Element WithHidden(string value) => (HtmlH5Element)WithAttribute(Attribute.Hidden(value));

		public HtmlH5Element WithId(string value) => (HtmlH5Element)WithAttribute(Attribute.Id(value));

		public HtmlH5Element WithLang(string value) => (HtmlH5Element)WithAttribute(Attribute.Lang(value));

		public HtmlH5Element WithSpellCheck(string value) => (HtmlH5Element)WithAttribute(Attribute.SpellCheck(value));

		public HtmlH5Element WithStyle(string value) => (HtmlH5Element)WithAttribute(Attribute.Style(value));

		public HtmlH5Element WithTabIndex(string value) => (HtmlH5Element)WithAttribute(Attribute.TabIndex(value));
    }
}
