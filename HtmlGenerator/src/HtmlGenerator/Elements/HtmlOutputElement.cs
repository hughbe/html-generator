namespace HtmlGenerator
{
    public class HtmlOutputElement : HtmlElement 
    {
        internal HtmlOutputElement() : base("output", false) 
        {    
        }

		public HtmlOutputElement WithForAttribute(string value) => (HtmlOutputElement)WithAttribute(Attribute.For(value));

		public HtmlOutputElement WithFormAttribute(string value) => (HtmlOutputElement)WithAttribute(Attribute.Form(value));

		public HtmlOutputElement WithNameAttribute(string value) => (HtmlOutputElement)WithAttribute(Attribute.Name(value));
    }
}
