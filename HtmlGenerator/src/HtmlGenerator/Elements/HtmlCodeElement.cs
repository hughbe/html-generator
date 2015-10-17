namespace HtmlGenerator
{
    public class HtmlCodeElement : HtmlElement 
    {
        public HtmlCodeElement() : base("code", false) 
        {    
        }

		public HtmlCodeElement WithAccessKey(string value) => (HtmlCodeElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlCodeElement WithClass(string value) => (HtmlCodeElement)WithAttribute(Attribute.Class(value));

		public HtmlCodeElement WithContentEditable(string value) => (HtmlCodeElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlCodeElement WithContextMenu(string value) => (HtmlCodeElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlCodeElement WithDir(string value) => (HtmlCodeElement)WithAttribute(Attribute.Dir(value));

		public HtmlCodeElement WithHidden(string value) => (HtmlCodeElement)WithAttribute(Attribute.Hidden(value));

		public HtmlCodeElement WithId(string value) => (HtmlCodeElement)WithAttribute(Attribute.Id(value));

		public HtmlCodeElement WithLang(string value) => (HtmlCodeElement)WithAttribute(Attribute.Lang(value));

		public HtmlCodeElement WithSpellCheck(string value) => (HtmlCodeElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlCodeElement WithStyle(string value) => (HtmlCodeElement)WithAttribute(Attribute.Style(value));

		public HtmlCodeElement WithTabIndex(string value) => (HtmlCodeElement)WithAttribute(Attribute.TabIndex(value));
    }
}
