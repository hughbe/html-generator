namespace HtmlGenerator
{
    public class HtmlAbbrElement : HtmlElement 
    {
        public HtmlAbbrElement() : base("abbr", false) 
        {    
        }

		public HtmlAbbrElement WithAccessKey(string value) => (HtmlAbbrElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlAbbrElement WithClass(string value) => (HtmlAbbrElement)WithAttribute(Attribute.Class(value));

		public HtmlAbbrElement WithContentEditable(string value) => (HtmlAbbrElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlAbbrElement WithContextMenu(string value) => (HtmlAbbrElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlAbbrElement WithDir(string value) => (HtmlAbbrElement)WithAttribute(Attribute.Dir(value));

		public HtmlAbbrElement WithHidden(string value) => (HtmlAbbrElement)WithAttribute(Attribute.Hidden(value));

		public HtmlAbbrElement WithId(string value) => (HtmlAbbrElement)WithAttribute(Attribute.Id(value));

		public HtmlAbbrElement WithLang(string value) => (HtmlAbbrElement)WithAttribute(Attribute.Lang(value));

		public HtmlAbbrElement WithSpellCheck(string value) => (HtmlAbbrElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlAbbrElement WithStyle(string value) => (HtmlAbbrElement)WithAttribute(Attribute.Style(value));

		public HtmlAbbrElement WithTabIndex(string value) => (HtmlAbbrElement)WithAttribute(Attribute.TabIndex(value));
    }
}
