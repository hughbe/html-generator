namespace HtmlGenerator
{
    public class HtmlSectionElement : HtmlElement 
    {
        public HtmlSectionElement() : base("section", false) 
        {    
        }

		public HtmlSectionElement WithAccessKey(string value) => (HtmlSectionElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSectionElement WithClass(string value) => (HtmlSectionElement)WithAttribute(Attribute.Class(value));

		public HtmlSectionElement WithContentEditable(string value) => (HtmlSectionElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSectionElement WithContextMenu(string value) => (HtmlSectionElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSectionElement WithDir(string value) => (HtmlSectionElement)WithAttribute(Attribute.Dir(value));

		public HtmlSectionElement WithHidden(string value) => (HtmlSectionElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSectionElement WithId(string value) => (HtmlSectionElement)WithAttribute(Attribute.Id(value));

		public HtmlSectionElement WithLang(string value) => (HtmlSectionElement)WithAttribute(Attribute.Lang(value));

		public HtmlSectionElement WithSpellCheck(string value) => (HtmlSectionElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSectionElement WithStyle(string value) => (HtmlSectionElement)WithAttribute(Attribute.Style(value));

		public HtmlSectionElement WithTabIndex(string value) => (HtmlSectionElement)WithAttribute(Attribute.TabIndex(value));
    }
}
