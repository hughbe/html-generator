namespace HtmlGenerator
{
    public class HtmlTableElement : HtmlElement 
    {
        public HtmlTableElement() : base("table", false) 
        {    
        }

		public HtmlTableElement WithAccessKey(string value) => (HtmlTableElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTableElement WithClass(string value) => (HtmlTableElement)WithAttribute(Attribute.Class(value));

		public HtmlTableElement WithContentEditable(string value) => (HtmlTableElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTableElement WithContextMenu(string value) => (HtmlTableElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTableElement WithDir(string value) => (HtmlTableElement)WithAttribute(Attribute.Dir(value));

		public HtmlTableElement WithHidden(string value) => (HtmlTableElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTableElement WithId(string value) => (HtmlTableElement)WithAttribute(Attribute.Id(value));

		public HtmlTableElement WithLang(string value) => (HtmlTableElement)WithAttribute(Attribute.Lang(value));

		public HtmlTableElement WithSpellCheck(string value) => (HtmlTableElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTableElement WithStyle(string value) => (HtmlTableElement)WithAttribute(Attribute.Style(value));

		public HtmlTableElement WithTabIndex(string value) => (HtmlTableElement)WithAttribute(Attribute.TabIndex(value));
    }
}
