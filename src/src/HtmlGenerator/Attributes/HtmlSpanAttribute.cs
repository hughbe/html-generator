namespace HtmlGenerator
{
    public class HtmlSpanAttribute : HtmlAttribute 
    {
        public HtmlSpanAttribute() : base("span", "Span", null, false, false) 
        {
        }

        public HtmlSpanAttribute(string value) : base("span", "Span", value, false, false) 
        {
        }
    }
}
