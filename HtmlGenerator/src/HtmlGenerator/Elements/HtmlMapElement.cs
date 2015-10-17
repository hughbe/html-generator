namespace HtmlGenerator
{
    public class HtmlMapElement : HtmlElement 
    {
        internal HtmlMapElement() : base("map", false) 
        {    
        }

		public HtmlMapElement WithNameAttribute(string value) => (HtmlMapElement)WithAttribute(Attribute.Name(value));
    }
}
