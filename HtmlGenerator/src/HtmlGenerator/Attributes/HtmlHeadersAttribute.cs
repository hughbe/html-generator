namespace HtmlGenerator
{
    public class HtmlHeadersAttribute : HtmlAttribute 
    {
        public HtmlHeadersAttribute() : base("headers", "Headers", null, false, false) 
        {
        }

        public HtmlHeadersAttribute(string value) : base("headers", "Headers", value, false, false) 
        {
        }
    }
}
