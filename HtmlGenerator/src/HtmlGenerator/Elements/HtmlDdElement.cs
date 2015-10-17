namespace HtmlGenerator
{
    public class HtmlDdElement : HtmlElement 
    {
        internal HtmlDdElement() : base("dd", false) 
        {    
        }

		public HtmlDdElement WithNoWrap(string value) => (HtmlDdElement)WithAttribute(Attribute.NoWrap(value));

		public HtmlDdElement WithAccessKey(string value) => (HtmlDdElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDdElement WithClass(string value) => (HtmlDdElement)WithAttribute(Attribute.Class(value));

		public HtmlDdElement WithContentEditable(string value) => (HtmlDdElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDdElement WithContextMenu(string value) => (HtmlDdElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDdElement WithDir(string value) => (HtmlDdElement)WithAttribute(Attribute.Dir(value));

		public HtmlDdElement WithHidden(string value) => (HtmlDdElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDdElement WithId(string value) => (HtmlDdElement)WithAttribute(Attribute.Id(value));

		public HtmlDdElement WithLang(string value) => (HtmlDdElement)WithAttribute(Attribute.Lang(value));

		public HtmlDdElement WithSpellCheck(string value) => (HtmlDdElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDdElement WithStyle(string value) => (HtmlDdElement)WithAttribute(Attribute.Style(value));

		public HtmlDdElement WithTabIndex(string value) => (HtmlDdElement)WithAttribute(Attribute.TabIndex(value));
    }
}
