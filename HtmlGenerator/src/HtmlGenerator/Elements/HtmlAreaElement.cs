namespace HtmlGenerator
{
    public class HtmlAreaElement : HtmlElement 
    {
        internal HtmlAreaElement() : base("area", true) 
        {    
        }

		public HtmlAreaElement WithAlt(string value) => (HtmlAreaElement)WithAttribute(Attribute.Alt(value));

		public HtmlAreaElement WithCoords(string value) => (HtmlAreaElement)WithAttribute(Attribute.Coords(value));

		public HtmlAreaElement WithDownload(string value) => (HtmlAreaElement)WithAttribute(Attribute.Download(value));

		public HtmlAreaElement WithHref(string value) => (HtmlAreaElement)WithAttribute(Attribute.Href(value));

		public HtmlAreaElement WithHrefLang(string value) => (HtmlAreaElement)WithAttribute(Attribute.HrefLang(value));

		public HtmlAreaElement WithMedia(string value) => (HtmlAreaElement)WithAttribute(Attribute.Media(value));

		public HtmlAreaElement WithRel(string value) => (HtmlAreaElement)WithAttribute(Attribute.Rel(value));

		public HtmlAreaElement WithShape(string value) => (HtmlAreaElement)WithAttribute(Attribute.Shape(value));

		public HtmlAreaElement WithTarget(string value) => (HtmlAreaElement)WithAttribute(Attribute.Target(value));

		public HtmlAreaElement WithType(string value) => (HtmlAreaElement)WithAttribute(Attribute.Type(value));

		public HtmlAreaElement WithAccessKey(string value) => (HtmlAreaElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlAreaElement WithClass(string value) => (HtmlAreaElement)WithAttribute(Attribute.Class(value));

		public HtmlAreaElement WithContentEditable(string value) => (HtmlAreaElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlAreaElement WithContextMenu(string value) => (HtmlAreaElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlAreaElement WithDir(string value) => (HtmlAreaElement)WithAttribute(Attribute.Dir(value));

		public HtmlAreaElement WithHidden(string value) => (HtmlAreaElement)WithAttribute(Attribute.Hidden(value));

		public HtmlAreaElement WithId(string value) => (HtmlAreaElement)WithAttribute(Attribute.Id(value));

		public HtmlAreaElement WithLang(string value) => (HtmlAreaElement)WithAttribute(Attribute.Lang(value));

		public HtmlAreaElement WithSpellCheck(string value) => (HtmlAreaElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlAreaElement WithStyle(string value) => (HtmlAreaElement)WithAttribute(Attribute.Style(value));

		public HtmlAreaElement WithTabIndex(string value) => (HtmlAreaElement)WithAttribute(Attribute.TabIndex(value));
    }
}
