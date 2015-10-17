namespace HtmlGenerator
{
    public class HtmlEmElement : HtmlElement 
    {
        public HtmlEmElement() : base("em", false) 
        {    
        }

		public HtmlEmElement WithAccessKey(string value) => (HtmlEmElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlEmElement WithClass(string value) => (HtmlEmElement)WithAttribute(Attribute.Class(value));

		public HtmlEmElement WithContentEditable(string value) => (HtmlEmElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlEmElement WithContextMenu(string value) => (HtmlEmElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlEmElement WithDir(string value) => (HtmlEmElement)WithAttribute(Attribute.Dir(value));

		public HtmlEmElement WithHidden(string value) => (HtmlEmElement)WithAttribute(Attribute.Hidden(value));

		public HtmlEmElement WithId(string value) => (HtmlEmElement)WithAttribute(Attribute.Id(value));

		public HtmlEmElement WithLang(string value) => (HtmlEmElement)WithAttribute(Attribute.Lang(value));

		public HtmlEmElement WithSpellCheck(string value) => (HtmlEmElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlEmElement WithStyle(string value) => (HtmlEmElement)WithAttribute(Attribute.Style(value));

		public HtmlEmElement WithTabIndex(string value) => (HtmlEmElement)WithAttribute(Attribute.TabIndex(value));
    }
}
