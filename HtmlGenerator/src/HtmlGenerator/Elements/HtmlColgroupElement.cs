namespace HtmlGenerator
{
    public class HtmlColgroupElement : HtmlElement 
    {
        internal HtmlColgroupElement() : base("colgroup", false) 
        {    
        }

		public HtmlColgroupElement WithSpan(string value) => (HtmlColgroupElement)WithAttribute(Attribute.Span(value));

		public HtmlColgroupElement WithAccessKey(string value) => (HtmlColgroupElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlColgroupElement WithClass(string value) => (HtmlColgroupElement)WithAttribute(Attribute.Class(value));

		public HtmlColgroupElement WithContentEditable(string value) => (HtmlColgroupElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlColgroupElement WithContextMenu(string value) => (HtmlColgroupElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlColgroupElement WithDir(string value) => (HtmlColgroupElement)WithAttribute(Attribute.Dir(value));

		public HtmlColgroupElement WithHidden(string value) => (HtmlColgroupElement)WithAttribute(Attribute.Hidden(value));

		public HtmlColgroupElement WithId(string value) => (HtmlColgroupElement)WithAttribute(Attribute.Id(value));

		public HtmlColgroupElement WithLang(string value) => (HtmlColgroupElement)WithAttribute(Attribute.Lang(value));

		public HtmlColgroupElement WithSpellCheck(string value) => (HtmlColgroupElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlColgroupElement WithStyle(string value) => (HtmlColgroupElement)WithAttribute(Attribute.Style(value));

		public HtmlColgroupElement WithTabIndex(string value) => (HtmlColgroupElement)WithAttribute(Attribute.TabIndex(value));
    }
}
