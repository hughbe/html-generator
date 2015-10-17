namespace HtmlGenerator
{
    public class HtmlMainElement : HtmlElement 
    {
        public HtmlMainElement() : base("main", false) 
        {    
        }

		public HtmlMainElement WithAccessKey(string value) => (HtmlMainElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMainElement WithClass(string value) => (HtmlMainElement)WithAttribute(Attribute.Class(value));

		public HtmlMainElement WithContentEditable(string value) => (HtmlMainElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMainElement WithContextMenu(string value) => (HtmlMainElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMainElement WithDir(string value) => (HtmlMainElement)WithAttribute(Attribute.Dir(value));

		public HtmlMainElement WithHidden(string value) => (HtmlMainElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMainElement WithId(string value) => (HtmlMainElement)WithAttribute(Attribute.Id(value));

		public HtmlMainElement WithLang(string value) => (HtmlMainElement)WithAttribute(Attribute.Lang(value));

		public HtmlMainElement WithSpellCheck(string value) => (HtmlMainElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMainElement WithStyle(string value) => (HtmlMainElement)WithAttribute(Attribute.Style(value));

		public HtmlMainElement WithTabIndex(string value) => (HtmlMainElement)WithAttribute(Attribute.TabIndex(value));
    }
}
