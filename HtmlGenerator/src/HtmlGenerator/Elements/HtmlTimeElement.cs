namespace HtmlGenerator
{
    public class HtmlTimeElement : HtmlElement 
    {
        internal HtmlTimeElement() : base("time", false) 
        {    
        }

		public HtmlTimeElement WithDateTimeAttribute(string value) => (HtmlTimeElement)WithAttribute(Attribute.DateTime(value));
    }
}
