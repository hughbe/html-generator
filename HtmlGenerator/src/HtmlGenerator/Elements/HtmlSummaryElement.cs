namespace HtmlGenerator
{
    public class HtmlSummaryElement : HtmlElement 
    {
        internal HtmlSummaryElement() : base("summary", false) 
        {    
        }

		public HtmlSummaryElement WithAccessKey(string value) => (HtmlSummaryElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSummaryElement WithClass(string value) => (HtmlSummaryElement)WithAttribute(Attribute.Class(value));

		public HtmlSummaryElement WithContentEditable(string value) => (HtmlSummaryElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSummaryElement WithContextMenu(string value) => (HtmlSummaryElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSummaryElement WithDir(string value) => (HtmlSummaryElement)WithAttribute(Attribute.Dir(value));

		public HtmlSummaryElement WithHidden(string value) => (HtmlSummaryElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSummaryElement WithId(string value) => (HtmlSummaryElement)WithAttribute(Attribute.Id(value));

		public HtmlSummaryElement WithLang(string value) => (HtmlSummaryElement)WithAttribute(Attribute.Lang(value));

		public HtmlSummaryElement WithSpellCheck(string value) => (HtmlSummaryElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSummaryElement WithStyle(string value) => (HtmlSummaryElement)WithAttribute(Attribute.Style(value));

		public HtmlSummaryElement WithTabIndex(string value) => (HtmlSummaryElement)WithAttribute(Attribute.TabIndex(value));
    }
}
