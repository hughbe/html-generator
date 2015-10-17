namespace HtmlGenerator
{
    public class HtmlFormElement : HtmlElement 
    {
        internal HtmlFormElement() : base("form", false) 
        {    
        }

		public HtmlFormElement WithAcceptCharsetAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.AcceptCharset(value));

		public HtmlFormElement WithActionAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.Action(value));

		public HtmlFormElement WithAutoCompleteAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.AutoComplete(value));

		public HtmlFormElement WithEncTypeAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.EncType(value));

		public HtmlFormElement WithMethodAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.Method(value));

		public HtmlFormElement WithNameAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.Name(value));

		public HtmlFormElement WithNoValidateAttribute() => (HtmlFormElement)WithAttribute(Attribute.NoValidate);

		public HtmlFormElement WithTargetAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.Target(value));
    }
}
