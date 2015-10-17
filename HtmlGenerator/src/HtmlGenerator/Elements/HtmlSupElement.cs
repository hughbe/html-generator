namespace HtmlGenerator
{
    public class HtmlSupElement : HtmlElement 
    {
        public HtmlSupElement() : base("sup", false) 
        {    
        }

		public HtmlSupElement WithAccessKey(string value) => (HtmlSupElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSupElement WithClass(string value) => (HtmlSupElement)WithAttribute(Attribute.Class(value));

		public HtmlSupElement WithContentEditable(string value) => (HtmlSupElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSupElement WithContextMenu(string value) => (HtmlSupElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSupElement WithDir(string value) => (HtmlSupElement)WithAttribute(Attribute.Dir(value));

		public HtmlSupElement WithHidden(string value) => (HtmlSupElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSupElement WithId(string value) => (HtmlSupElement)WithAttribute(Attribute.Id(value));

		public HtmlSupElement WithLang(string value) => (HtmlSupElement)WithAttribute(Attribute.Lang(value));

		public HtmlSupElement WithSpellCheck(string value) => (HtmlSupElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSupElement WithStyle(string value) => (HtmlSupElement)WithAttribute(Attribute.Style(value));

		public HtmlSupElement WithTabIndex(string value) => (HtmlSupElement)WithAttribute(Attribute.TabIndex(value));
    }
}
