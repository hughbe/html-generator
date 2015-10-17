namespace HtmlGenerator
{
    public class HtmlAreaElement : HtmlElement 
    {
        internal HtmlAreaElement() : base("area", true) 
        {    
        }

		public HtmlAreaElement WithAltAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.Alt(value));

		public HtmlAreaElement WithCoordsAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.Coords(value));

		public HtmlAreaElement WithDownloadAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.Download(value));

		public HtmlAreaElement WithHrefAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.Href(value));

		public HtmlAreaElement WithHrefLangAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.HrefLang(value));

		public HtmlAreaElement WithMediaAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.Media(value));

		public HtmlAreaElement WithRelAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.Rel(value));

		public HtmlAreaElement WithShapeAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.Shape(value));

		public HtmlAreaElement WithTargetAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.Target(value));

		public HtmlAreaElement WithTypeAttribute(string value) => (HtmlAreaElement)WithAttribute(Attribute.Type(value));
    }
}
