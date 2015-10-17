namespace HtmlGenerator
{
    public class HtmlTitleElement : HtmlElement 
    {
        internal HtmlTitleElement() : base("title", false) 
        {    
        }

		public HtmlTitleElement WithAccessKey(string value) => (HtmlTitleElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTitleElement WithClass(string value) => (HtmlTitleElement)WithAttribute(Attribute.Class(value));

		public HtmlTitleElement WithContentEditable(string value) => (HtmlTitleElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTitleElement WithContextMenuAttribute(string value) => (HtmlTitleElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTitleElement WithDir(string value) => (HtmlTitleElement)WithAttribute(Attribute.Dir(value));

		public HtmlTitleElement WithHidden(string value) => (HtmlTitleElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTitleElement WithId(string value) => (HtmlTitleElement)WithAttribute(Attribute.Id(value));

		public HtmlTitleElement WithLang(string value) => (HtmlTitleElement)WithAttribute(Attribute.Lang(value));

		public HtmlTitleElement WithSpellCheck(string value) => (HtmlTitleElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTitleElement WithStyleAttribute(string value) => (HtmlTitleElement)WithAttribute(Attribute.Style(value));

		public HtmlTitleElement WithTabIndex(string value) => (HtmlTitleElement)WithAttribute(Attribute.TabIndex(value));
    }
}
