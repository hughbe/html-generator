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
    }
}
