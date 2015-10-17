namespace HtmlGenerator
{
    public class HtmlColElement : HtmlElement 
    {
        internal HtmlColElement() : base("col", true) 
        {    
        }

		public HtmlColElement WithSpanAttribute(string value) => (HtmlColElement)WithAttribute(Attribute.Span(value));
    }
}
