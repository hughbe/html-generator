namespace HtmlGenerator
{
    public class HtmlNoscriptElement : HtmlElement 
    {
        internal HtmlNoscriptElement() : base("noscript", false) 
        {    
        }

		public HtmlNoscriptElement WithAccessKey(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlNoscriptElement WithClass(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.Class(value));

		public HtmlNoscriptElement WithContentEditable(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlNoscriptElement WithContextMenu(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlNoscriptElement WithDir(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.Dir(value));

		public HtmlNoscriptElement WithHidden(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.Hidden(value));

		public HtmlNoscriptElement WithId(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.Id(value));

		public HtmlNoscriptElement WithLang(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.Lang(value));

		public HtmlNoscriptElement WithSpellCheck(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlNoscriptElement WithStyle(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.Style(value));

		public HtmlNoscriptElement WithTabIndex(string value) => (HtmlNoscriptElement)WithAttribute(Attribute.TabIndex(value));
    }
}
