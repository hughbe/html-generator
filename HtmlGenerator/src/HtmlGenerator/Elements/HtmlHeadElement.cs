namespace HtmlGenerator
{
    public class HtmlHeadElement : HtmlElement 
    {
        public HtmlHeadElement() : base("head", false) 
        {    
        }

		public HtmlHeadElement WithAccessKey(string value) => (HtmlHeadElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlHeadElement WithClass(string value) => (HtmlHeadElement)WithAttribute(Attribute.Class(value));

		public HtmlHeadElement WithContentEditable(string value) => (HtmlHeadElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlHeadElement WithContextMenu(string value) => (HtmlHeadElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlHeadElement WithDir(string value) => (HtmlHeadElement)WithAttribute(Attribute.Dir(value));

		public HtmlHeadElement WithHidden(string value) => (HtmlHeadElement)WithAttribute(Attribute.Hidden(value));

		public HtmlHeadElement WithId(string value) => (HtmlHeadElement)WithAttribute(Attribute.Id(value));

		public HtmlHeadElement WithLang(string value) => (HtmlHeadElement)WithAttribute(Attribute.Lang(value));

		public HtmlHeadElement WithSpellCheck(string value) => (HtmlHeadElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlHeadElement WithStyle(string value) => (HtmlHeadElement)WithAttribute(Attribute.Style(value));

		public HtmlHeadElement WithTabIndex(string value) => (HtmlHeadElement)WithAttribute(Attribute.TabIndex(value));
    }
}
