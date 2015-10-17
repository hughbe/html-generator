namespace HtmlGenerator
{
    public class HtmlSelectElement : HtmlElement 
    {
        internal HtmlSelectElement() : base("select", false) 
        {    
        }

		public HtmlSelectElement WithAutoFocusAttribute() => (HtmlSelectElement)WithAttribute(Attribute.AutoFocus);

		public HtmlSelectElement WithDisabledAttribute() => (HtmlSelectElement)WithAttribute(Attribute.Disabled);

		public HtmlSelectElement WithFormAttribute(string value) => (HtmlSelectElement)WithAttribute(Attribute.Form(value));

		public HtmlSelectElement WithMultipleAttribute() => (HtmlSelectElement)WithAttribute(Attribute.Multiple);

		public HtmlSelectElement WithNameAttribute(string value) => (HtmlSelectElement)WithAttribute(Attribute.Name(value));

		public HtmlSelectElement WithRequiredAttribute() => (HtmlSelectElement)WithAttribute(Attribute.Required);

		public HtmlSelectElement WithSizeAttribute(string value) => (HtmlSelectElement)WithAttribute(Attribute.Size(value));
    }
}
