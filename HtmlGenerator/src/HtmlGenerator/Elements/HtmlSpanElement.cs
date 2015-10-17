namespace HtmlGenerator
{
    public class HtmlSpanElement : HtmlElement 
    {
        internal HtmlSpanElement() : base("span", false) 
        {    
        }

		public HtmlSpanElement WithAccessKey(string value) => (HtmlSpanElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSpanElement WithClass(string value) => (HtmlSpanElement)WithAttribute(Attribute.Class(value));

		public HtmlSpanElement WithContentEditable(string value) => (HtmlSpanElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSpanElement WithContextMenu(string value) => (HtmlSpanElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSpanElement WithDir(string value) => (HtmlSpanElement)WithAttribute(Attribute.Dir(value));

		public HtmlSpanElement WithHidden(string value) => (HtmlSpanElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSpanElement WithId(string value) => (HtmlSpanElement)WithAttribute(Attribute.Id(value));

		public HtmlSpanElement WithLang(string value) => (HtmlSpanElement)WithAttribute(Attribute.Lang(value));

		public HtmlSpanElement WithSpellCheck(string value) => (HtmlSpanElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSpanElement WithStyle(string value) => (HtmlSpanElement)WithAttribute(Attribute.Style(value));

		public HtmlSpanElement WithTabIndex(string value) => (HtmlSpanElement)WithAttribute(Attribute.TabIndex(value));
    }
}
