namespace HtmlGenerator
{
    public class HtmlBElement : HtmlElement 
    {
        internal HtmlBElement() : base("b", false) 
        {    
        }

		public HtmlBElement WithAccessKey(string value) => (HtmlBElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlBElement WithClass(string value) => (HtmlBElement)WithAttribute(Attribute.Class(value));

		public HtmlBElement WithContentEditable(string value) => (HtmlBElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlBElement WithContextMenu(string value) => (HtmlBElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlBElement WithDir(string value) => (HtmlBElement)WithAttribute(Attribute.Dir(value));

		public HtmlBElement WithHidden(string value) => (HtmlBElement)WithAttribute(Attribute.Hidden(value));

		public HtmlBElement WithId(string value) => (HtmlBElement)WithAttribute(Attribute.Id(value));

		public HtmlBElement WithLang(string value) => (HtmlBElement)WithAttribute(Attribute.Lang(value));

		public HtmlBElement WithSpellCheck(string value) => (HtmlBElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlBElement WithStyle(string value) => (HtmlBElement)WithAttribute(Attribute.Style(value));

		public HtmlBElement WithTabIndex(string value) => (HtmlBElement)WithAttribute(Attribute.TabIndex(value));
    }
}
