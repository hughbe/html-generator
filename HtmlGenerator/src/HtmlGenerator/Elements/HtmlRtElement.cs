namespace HtmlGenerator
{
    public class HtmlRtElement : HtmlElement 
    {
        public HtmlRtElement() : base("rt", false) 
        {    
        }

		public HtmlRtElement WithAccessKey(string value) => (HtmlRtElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlRtElement WithClass(string value) => (HtmlRtElement)WithAttribute(Attribute.Class(value));

		public HtmlRtElement WithContentEditable(string value) => (HtmlRtElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlRtElement WithContextMenu(string value) => (HtmlRtElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlRtElement WithDir(string value) => (HtmlRtElement)WithAttribute(Attribute.Dir(value));

		public HtmlRtElement WithHidden(string value) => (HtmlRtElement)WithAttribute(Attribute.Hidden(value));

		public HtmlRtElement WithId(string value) => (HtmlRtElement)WithAttribute(Attribute.Id(value));

		public HtmlRtElement WithLang(string value) => (HtmlRtElement)WithAttribute(Attribute.Lang(value));

		public HtmlRtElement WithSpellCheck(string value) => (HtmlRtElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlRtElement WithStyle(string value) => (HtmlRtElement)WithAttribute(Attribute.Style(value));

		public HtmlRtElement WithTabIndex(string value) => (HtmlRtElement)WithAttribute(Attribute.TabIndex(value));
    }
}
