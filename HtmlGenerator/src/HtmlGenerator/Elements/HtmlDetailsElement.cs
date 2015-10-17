namespace HtmlGenerator
{
    public class HtmlDetailsElement : HtmlElement 
    {
        internal HtmlDetailsElement() : base("details", false) 
        {    
        }

		public HtmlDetailsElement WithOpenAttribute(string value) => (HtmlDetailsElement)WithAttribute(Attribute.Open(value));
    }
}
