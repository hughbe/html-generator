namespace HtmlGenerator
{
    public class HtmlParamElement : HtmlElement 
    {
        internal HtmlParamElement() : base("param", true) 
        {    
        }

		public HtmlParamElement WithNameAttribute(string value) => (HtmlParamElement)WithAttribute(Attribute.Name(value));

		public HtmlParamElement WithValueAttribute(string value) => (HtmlParamElement)WithAttribute(Attribute.Value(value));
    }
}
