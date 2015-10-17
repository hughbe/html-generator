namespace HtmlGenerator
{
    public class HtmlDdElement : HtmlElement 
    {
        internal HtmlDdElement() : base("dd", false) 
        {    
        }

		public HtmlDdElement WithNoWrapAttribute(string value) => (HtmlDdElement)WithAttribute(Attribute.NoWrap(value));
    }
}
