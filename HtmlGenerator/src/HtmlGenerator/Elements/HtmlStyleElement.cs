namespace HtmlGenerator
{
    public class HtmlStyleElement : HtmlElement 
    {
        internal HtmlStyleElement() : base("style", false) 
        {    
        }

		public HtmlStyleElement WithTypeAttribute(string value) => (HtmlStyleElement)WithAttribute(Attribute.Type(value));

		public HtmlStyleElement WithMediaAttribute(string value) => (HtmlStyleElement)WithAttribute(Attribute.Media(value));

		public HtmlStyleElement WithScopedAttribute() => (HtmlStyleElement)WithAttribute(Attribute.Scoped);

		public HtmlStyleElement WithTitleAttribute(string value) => (HtmlStyleElement)WithAttribute(Attribute.Title(value));

		public HtmlStyleElement WithDisabledAttribute() => (HtmlStyleElement)WithAttribute(Attribute.Disabled);
    }
}
