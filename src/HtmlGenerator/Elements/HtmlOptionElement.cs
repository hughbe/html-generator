namespace HtmlGenerator
{
    public class HtmlOptionElement : HtmlElement
    {
        public HtmlOptionElement() : base("option", false) 
        {    
        }

		public HtmlOptionElement WithDisabled() => this.WithAttribute(Attribute.Disabled);

		public HtmlOptionElement WithLabel(string value) => this.WithAttribute(Attribute.Label(value));

		public HtmlOptionElement WithSelected() => this.WithAttribute(Attribute.Selected);

		public HtmlOptionElement WithValue(string value) => this.WithAttribute(Attribute.Value(value));
    }
}
