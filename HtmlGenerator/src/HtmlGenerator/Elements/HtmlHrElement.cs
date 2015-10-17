namespace HtmlGenerator
{
    public class HtmlHrElement : HtmlElement 
    {
        internal HtmlHrElement() : base("hr", true) 
        {    
        }

		public HtmlHrElement WithColorAttribute(string value) => (HtmlHrElement)WithAttribute(Attribute.Color(value));
    }
}
