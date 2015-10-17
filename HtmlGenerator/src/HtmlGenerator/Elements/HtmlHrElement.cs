namespace HtmlGenerator
{
    public class HtmlHrElement : HtmlElement 
    {
        internal HtmlHrElement() : base("hr", true) 
        {    
        }

		public HtmlHrElement WithColorAttribute(string value) => (HtmlHrElement)WithAttribute(Attribute.Color(value));

		public HtmlHrElement WithAccessKey(string value) => (HtmlHrElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlHrElement WithClass(string value) => (HtmlHrElement)WithAttribute(Attribute.Class(value));

		public HtmlHrElement WithContentEditable(string value) => (HtmlHrElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlHrElement WithContextMenuAttribute(string value) => (HtmlHrElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlHrElement WithDir(string value) => (HtmlHrElement)WithAttribute(Attribute.Dir(value));

		public HtmlHrElement WithHidden(string value) => (HtmlHrElement)WithAttribute(Attribute.Hidden(value));

		public HtmlHrElement WithId(string value) => (HtmlHrElement)WithAttribute(Attribute.Id(value));

		public HtmlHrElement WithLang(string value) => (HtmlHrElement)WithAttribute(Attribute.Lang(value));

		public HtmlHrElement WithSpellCheck(string value) => (HtmlHrElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlHrElement WithStyleAttribute(string value) => (HtmlHrElement)WithAttribute(Attribute.Style(value));

		public HtmlHrElement WithTabIndex(string value) => (HtmlHrElement)WithAttribute(Attribute.TabIndex(value));
    }
}
