namespace HtmlGenerator
{
    public class HtmlObjectElement : HtmlElement 
    {
        internal HtmlObjectElement() : base("object", false) 
        {    
        }

		public HtmlObjectElement WithDataAttribute(string value) => (HtmlObjectElement)WithAttribute(Attribute.Data(value));

		public HtmlObjectElement WithFormAttribute(string value) => (HtmlObjectElement)WithAttribute(Attribute.Form(value));

		public HtmlObjectElement WithHeightAttribute(string value) => (HtmlObjectElement)WithAttribute(Attribute.Height(value));

		public HtmlObjectElement WithNameAttribute(string value) => (HtmlObjectElement)WithAttribute(Attribute.Name(value));

		public HtmlObjectElement WithTypeAttribute(string value) => (HtmlObjectElement)WithAttribute(Attribute.Type(value));

		public HtmlObjectElement WithTypeMustMatchAttribute() => (HtmlObjectElement)WithAttribute(Attribute.TypeMustMatch);

		public HtmlObjectElement WithUseMapAttribute(string value) => (HtmlObjectElement)WithAttribute(Attribute.UseMap(value));

		public HtmlObjectElement WithWidthAttribute(string value) => (HtmlObjectElement)WithAttribute(Attribute.Width(value));
    }
}
