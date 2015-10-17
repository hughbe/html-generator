namespace HtmlGenerator
{
    public class HtmlAElement : HtmlElement 
    {
        internal HtmlAElement() : base("a", false) 
        {    
        }

		public HtmlAElement WithDownloadAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Download(value));

		public HtmlAElement WithHrefAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Href(value));

		public HtmlAElement WithHrefLangAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.HrefLang(value));

		public HtmlAElement WithMediaAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Media(value));

		public HtmlAElement WithPingAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Ping(value));

		public HtmlAElement WithRelAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Rel(value));

		public HtmlAElement WithTargetAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Target(value));

		public HtmlAElement WithTypeAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Type(value));
    }
}
