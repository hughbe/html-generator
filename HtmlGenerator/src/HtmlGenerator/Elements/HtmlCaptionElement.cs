namespace HtmlGenerator
{
    public class HtmlCaptionElement : HtmlElement 
    {
        internal HtmlCaptionElement() : base("caption", false) 
        {    
        }

		public HtmlCaptionElement WithAccessKey(string value) => (HtmlCaptionElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlCaptionElement WithClass(string value) => (HtmlCaptionElement)WithAttribute(Attribute.Class(value));

		public HtmlCaptionElement WithContentEditable(string value) => (HtmlCaptionElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlCaptionElement WithContextMenu(string value) => (HtmlCaptionElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlCaptionElement WithDir(string value) => (HtmlCaptionElement)WithAttribute(Attribute.Dir(value));

		public HtmlCaptionElement WithHidden(string value) => (HtmlCaptionElement)WithAttribute(Attribute.Hidden(value));

		public HtmlCaptionElement WithId(string value) => (HtmlCaptionElement)WithAttribute(Attribute.Id(value));

		public HtmlCaptionElement WithLang(string value) => (HtmlCaptionElement)WithAttribute(Attribute.Lang(value));

		public HtmlCaptionElement WithSpellCheck(string value) => (HtmlCaptionElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlCaptionElement WithStyle(string value) => (HtmlCaptionElement)WithAttribute(Attribute.Style(value));

		public HtmlCaptionElement WithTabIndex(string value) => (HtmlCaptionElement)WithAttribute(Attribute.TabIndex(value));
    }
}
