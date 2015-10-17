namespace HtmlGenerator
{
    public class HtmlHeadersAttribute : HtmlAttribute 
    {
        internal HtmlHeadersAttribute() : base("headers", "Headers", null, false, false) 
        {
        }

        internal HtmlHeadersAttribute(string value) : base("headers", "Headers", value, false, false) 
        {
        }
    }
}
