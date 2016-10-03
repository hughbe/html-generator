namespace HtmlGenerator
{
    public class HtmlStyleElement : HtmlElement
    {
        public HtmlStyleElement() : base("style", false) 
        {    
        }

		public HtmlStyleElement WithDisabled() => this.WithAttribute(Attribute.Disabled);

		public HtmlStyleElement WithType(string value) => this.WithAttribute(Attribute.Type(value));

		public HtmlStyleElement WithMedia(string value) => this.WithAttribute(Attribute.Media(value));

		public HtmlStyleElement WithScoped() => this.WithAttribute(Attribute.Scoped);
    }
}
