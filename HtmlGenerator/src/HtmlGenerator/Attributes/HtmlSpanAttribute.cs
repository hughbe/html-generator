namespace HtmlGenerator
{
    public class HtmlSpanAttribute : HtmlAttribute 
    {
        internal HtmlSpanAttribute() : base("span", "Span", null, false, false) 
        {
        }

        internal HtmlSpanAttribute(string value) : base("span", "Span", value, false, false) 
        {
        }
    }
}
