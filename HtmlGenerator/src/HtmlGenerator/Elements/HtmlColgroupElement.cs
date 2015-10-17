namespace HtmlGenerator
{
    public class HtmlColgroupElement : HtmlElement 
    {
        internal HtmlColgroupElement() : base("colgroup", false) 
        {    
        }

		public HtmlColgroupElement WithSpanAttribute(string value) => (HtmlColgroupElement)WithAttribute(Attribute.Span(value));
    }
}
