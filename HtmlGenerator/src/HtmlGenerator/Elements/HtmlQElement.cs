namespace HtmlGenerator
{
    public class HtmlQElement : HtmlElement 
    {
        internal HtmlQElement() : base("q", false) 
        {    
        }

		public HtmlQElement WithCiteAttribute(string value) => (HtmlQElement)WithAttribute(Attribute.Cite(value));
    }
}
