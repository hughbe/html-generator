namespace HtmlGenerator
{
    public class HtmlUlElement : HtmlElement 
    {
        internal HtmlUlElement() : base("ul", false) 
        {    
        }

		public HtmlUlElement WithAccessKey(string value) => (HtmlUlElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlUlElement WithClass(string value) => (HtmlUlElement)WithAttribute(Attribute.Class(value));

		public HtmlUlElement WithContentEditable(string value) => (HtmlUlElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlUlElement WithContextMenu(string value) => (HtmlUlElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlUlElement WithDir(string value) => (HtmlUlElement)WithAttribute(Attribute.Dir(value));

		public HtmlUlElement WithHidden(string value) => (HtmlUlElement)WithAttribute(Attribute.Hidden(value));

		public HtmlUlElement WithId(string value) => (HtmlUlElement)WithAttribute(Attribute.Id(value));

		public HtmlUlElement WithLang(string value) => (HtmlUlElement)WithAttribute(Attribute.Lang(value));

		public HtmlUlElement WithSpellCheck(string value) => (HtmlUlElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlUlElement WithStyle(string value) => (HtmlUlElement)WithAttribute(Attribute.Style(value));

		public HtmlUlElement WithTabIndex(string value) => (HtmlUlElement)WithAttribute(Attribute.TabIndex(value));
    }
}
