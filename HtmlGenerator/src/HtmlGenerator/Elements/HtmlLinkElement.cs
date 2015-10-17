namespace HtmlGenerator
{
    public class HtmlLinkElement : HtmlElement 
    {
        internal HtmlLinkElement() : base("link", true) 
        {    
        }

		public HtmlLinkElement WithCrossOriginAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.CrossOrigin(value));

		public HtmlLinkElement WithHrefAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.Href(value));

		public HtmlLinkElement WithHrefLangAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.HrefLang(value));

		public HtmlLinkElement WithIntegrityAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.Integrity(value));

		public HtmlLinkElement WithMediaAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.Media(value));

		public HtmlLinkElement WithRelAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.Rel(value));

		public HtmlLinkElement WithSizesAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.Sizes(value));

		public HtmlLinkElement WithTypeAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.Type(value));

		public HtmlLinkElement WithAccessKey(string value) => (HtmlLinkElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlLinkElement WithClass(string value) => (HtmlLinkElement)WithAttribute(Attribute.Class(value));

		public HtmlLinkElement WithContentEditable(string value) => (HtmlLinkElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlLinkElement WithContextMenuAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlLinkElement WithDir(string value) => (HtmlLinkElement)WithAttribute(Attribute.Dir(value));

		public HtmlLinkElement WithHidden(string value) => (HtmlLinkElement)WithAttribute(Attribute.Hidden(value));

		public HtmlLinkElement WithId(string value) => (HtmlLinkElement)WithAttribute(Attribute.Id(value));

		public HtmlLinkElement WithLang(string value) => (HtmlLinkElement)WithAttribute(Attribute.Lang(value));

		public HtmlLinkElement WithSpellCheck(string value) => (HtmlLinkElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlLinkElement WithStyleAttribute(string value) => (HtmlLinkElement)WithAttribute(Attribute.Style(value));

		public HtmlLinkElement WithTabIndex(string value) => (HtmlLinkElement)WithAttribute(Attribute.TabIndex(value));
    }
}
