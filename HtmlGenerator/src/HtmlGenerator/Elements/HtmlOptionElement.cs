namespace HtmlGenerator
{
    public class HtmlOptionElement : HtmlElement 
    {
        internal HtmlOptionElement() : base("option", false) 
        {    
        }

		public HtmlOptionElement WithDisabledAttribute() => (HtmlOptionElement)WithAttribute(Attribute.Disabled);

		public HtmlOptionElement WithLabelAttribute(string value) => (HtmlOptionElement)WithAttribute(Attribute.Label(value));

		public HtmlOptionElement WithSelectedAttribute() => (HtmlOptionElement)WithAttribute(Attribute.Selected);

		public HtmlOptionElement WithValueAttribute(string value) => (HtmlOptionElement)WithAttribute(Attribute.Value(value));
    }
}
