namespace HtmlGenerator
{
    public class HtmlIElement : HtmlElement 
    {
        internal HtmlIElement() : base("i", false) 
        {    
        }

		public HtmlIElement WithAccessKey(string value) => (HtmlIElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlIElement WithClass(string value) => (HtmlIElement)WithAttribute(Attribute.Class(value));

		public HtmlIElement WithContentEditable(string value) => (HtmlIElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlIElement WithContextMenu(string value) => (HtmlIElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlIElement WithDir(string value) => (HtmlIElement)WithAttribute(Attribute.Dir(value));

		public HtmlIElement WithHidden(string value) => (HtmlIElement)WithAttribute(Attribute.Hidden(value));

		public HtmlIElement WithId(string value) => (HtmlIElement)WithAttribute(Attribute.Id(value));

		public HtmlIElement WithLang(string value) => (HtmlIElement)WithAttribute(Attribute.Lang(value));

		public HtmlIElement WithSpellCheck(string value) => (HtmlIElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlIElement WithStyle(string value) => (HtmlIElement)WithAttribute(Attribute.Style(value));

		public HtmlIElement WithTabIndex(string value) => (HtmlIElement)WithAttribute(Attribute.TabIndex(value));
    }
}
