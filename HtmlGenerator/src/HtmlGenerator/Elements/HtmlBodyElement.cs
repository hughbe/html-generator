namespace HtmlGenerator
{
    public class HtmlBodyElement : HtmlElement 
    {
        public HtmlBodyElement() : base("body", false) 
        {    
        }

		public HtmlBodyElement WithAccessKey(string value) => (HtmlBodyElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlBodyElement WithClass(string value) => (HtmlBodyElement)WithAttribute(Attribute.Class(value));

		public HtmlBodyElement WithContentEditable(string value) => (HtmlBodyElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlBodyElement WithContextMenu(string value) => (HtmlBodyElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlBodyElement WithDir(string value) => (HtmlBodyElement)WithAttribute(Attribute.Dir(value));

		public HtmlBodyElement WithHidden(string value) => (HtmlBodyElement)WithAttribute(Attribute.Hidden(value));

		public HtmlBodyElement WithId(string value) => (HtmlBodyElement)WithAttribute(Attribute.Id(value));

		public HtmlBodyElement WithLang(string value) => (HtmlBodyElement)WithAttribute(Attribute.Lang(value));

		public HtmlBodyElement WithSpellCheck(string value) => (HtmlBodyElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlBodyElement WithStyle(string value) => (HtmlBodyElement)WithAttribute(Attribute.Style(value));

		public HtmlBodyElement WithTabIndex(string value) => (HtmlBodyElement)WithAttribute(Attribute.TabIndex(value));
    }
}
