namespace HtmlGenerator
{
    public class HtmlButtonElement : HtmlElement 
    {
        internal HtmlButtonElement() : base("button", false) 
        {    
        }

		public HtmlButtonElement WithAutoFocusAttribute() => (HtmlButtonElement)WithAttribute(Attribute.AutoFocus);

		public HtmlButtonElement WithDisabledAttribute() => (HtmlButtonElement)WithAttribute(Attribute.Disabled);

		public HtmlButtonElement WithFormAttribute(string value) => (HtmlButtonElement)WithAttribute(Attribute.Form(value));

		public HtmlButtonElement WithFormActionAttribute(string value) => (HtmlButtonElement)WithAttribute(Attribute.FormAction(value));

		public HtmlButtonElement WithFormEncTypeAttribute(string value) => (HtmlButtonElement)WithAttribute(Attribute.FormEncType(value));

		public HtmlButtonElement WithFormMethodAttribute(string value) => (HtmlButtonElement)WithAttribute(Attribute.FormMethod(value));

		public HtmlButtonElement WithFormNoValidateAttribute() => (HtmlButtonElement)WithAttribute(Attribute.FormNoValidate);

		public HtmlButtonElement WithFormTargetAttribute(string value) => (HtmlButtonElement)WithAttribute(Attribute.FormTarget(value));

		public HtmlButtonElement WithNameAttribute(string value) => (HtmlButtonElement)WithAttribute(Attribute.Name(value));

		public HtmlButtonElement WithTypeAttribute(string value) => (HtmlButtonElement)WithAttribute(Attribute.Type(value));

		public HtmlButtonElement WithValueAttribute(string value) => (HtmlButtonElement)WithAttribute(Attribute.Value(value));
    }
}
