namespace HtmlGenerator
{
    public class HtmlFigCaptionElement : HtmlElement 
    {
        internal HtmlFigCaptionElement() : base("figcaption", false) 
        {    
        }

		public HtmlFigCaptionElement WithAccessKey(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlFigCaptionElement WithClass(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.Class(value));

		public HtmlFigCaptionElement WithContentEditable(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlFigCaptionElement WithContextMenu(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlFigCaptionElement WithDir(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.Dir(value));

		public HtmlFigCaptionElement WithHidden(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.Hidden(value));

		public HtmlFigCaptionElement WithId(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.Id(value));

		public HtmlFigCaptionElement WithLang(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.Lang(value));

		public HtmlFigCaptionElement WithSpellCheck(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlFigCaptionElement WithStyle(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.Style(value));

		public HtmlFigCaptionElement WithTabIndex(string value) => (HtmlFigCaptionElement)WithAttribute(Attribute.TabIndex(value));
    }
}
