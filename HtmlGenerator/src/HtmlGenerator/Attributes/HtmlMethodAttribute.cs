namespace HtmlGenerator
{
    public class HtmlMethodAttribute : HtmlAttribute 
    {
        internal HtmlMethodAttribute() : base("method", "Method", null, false, false) 
        {
        }

        internal HtmlMethodAttribute(string value) : base("method", "Method", value, false, false) 
        {
        }
    }
}
