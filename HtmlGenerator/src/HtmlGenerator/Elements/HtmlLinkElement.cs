namespace HtmlGenerator
{
    public class HtmlLinkElement : HtmlElement 
    {
        internal HtmlLinkElement() : base("link", true) 
        {    
        }

		public HtmlLinkElement WithCrossOrigin(string value) => (HtmlLinkElement)WithAttribute(Attribute.CrossOrigin(value));

		public HtmlLinkElement WithHref(string value) => (HtmlLinkElement)WithAttribute(Attribute.Href(value));

		public HtmlLinkElement WithHrefLang(string value) => (HtmlLinkElement)WithAttribute(Attribute.HrefLang(value));

		public HtmlLinkElement WithIntegrity(string value) => (HtmlLinkElement)WithAttribute(Attribute.Integrity(value));

		public HtmlLinkElement WithMedia(string value) => (HtmlLinkElement)WithAttribute(Attribute.Media(value));

		public HtmlLinkElement WithRel(string value) => (HtmlLinkElement)WithAttribute(Attribute.Rel(value));

		public HtmlLinkElement WithSizes(string value) => (HtmlLinkElement)WithAttribute(Attribute.Sizes(value));

		public HtmlLinkElement WithType(string value) => (HtmlLinkElement)WithAttribute(Attribute.Type(value));

		public HtmlLinkElement WithAccessKey(string value) => (HtmlLinkElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlLinkElement WithClass(string value) => (HtmlLinkElement)WithAttribute(Attribute.Class(value));

		public HtmlLinkElement WithContentEditable(string value) => (HtmlLinkElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlLinkElement WithContextMenu(string value) => (HtmlLinkElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlLinkElement WithDir(string value) => (HtmlLinkElement)WithAttribute(Attribute.Dir(value));

		public HtmlLinkElement WithHidden(string value) => (HtmlLinkElement)WithAttribute(Attribute.Hidden(value));

		public HtmlLinkElement WithId(string value) => (HtmlLinkElement)WithAttribute(Attribute.Id(value));

		public HtmlLinkElement WithLang(string value) => (HtmlLinkElement)WithAttribute(Attribute.Lang(value));

		public HtmlLinkElement WithSpellCheck(string value) => (HtmlLinkElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlLinkElement WithStyle(string value) => (HtmlLinkElement)WithAttribute(Attribute.Style(value));

		public HtmlLinkElement WithTabIndex(string value) => (HtmlLinkElement)WithAttribute(Attribute.TabIndex(value));
    }
}
