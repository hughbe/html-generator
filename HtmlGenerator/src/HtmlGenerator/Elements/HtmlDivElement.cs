namespace HtmlGenerator
{
    public class HtmlDivElement : HtmlElement 
    {
        public HtmlDivElement() : base("div", false) 
        {    
        }

		public HtmlDivElement WithAccessKey(string value) => (HtmlDivElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDivElement WithClass(string value) => (HtmlDivElement)WithAttribute(Attribute.Class(value));

		public HtmlDivElement WithContentEditable(string value) => (HtmlDivElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDivElement WithContextMenu(string value) => (HtmlDivElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDivElement WithDir(string value) => (HtmlDivElement)WithAttribute(Attribute.Dir(value));

		public HtmlDivElement WithHidden(string value) => (HtmlDivElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDivElement WithId(string value) => (HtmlDivElement)WithAttribute(Attribute.Id(value));

		public HtmlDivElement WithLang(string value) => (HtmlDivElement)WithAttribute(Attribute.Lang(value));

		public HtmlDivElement WithSpellCheck(string value) => (HtmlDivElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDivElement WithStyle(string value) => (HtmlDivElement)WithAttribute(Attribute.Style(value));

		public HtmlDivElement WithTabIndex(string value) => (HtmlDivElement)WithAttribute(Attribute.TabIndex(value));
    }
}
