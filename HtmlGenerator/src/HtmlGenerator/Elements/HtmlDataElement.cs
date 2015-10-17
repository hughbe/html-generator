namespace HtmlGenerator
{
    public class HtmlDataElement : HtmlElement 
    {
        internal HtmlDataElement() : base("data", false) 
        {    
        }

		public HtmlDataElement WithValueAttribute(string value) => (HtmlDataElement)WithAttribute(Attribute.Value(value));
    }
}
