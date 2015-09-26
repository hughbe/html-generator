namespace HtmlGenerator
{
    public class HtmlMethodAttribute : HtmlAttribute 
    {
        public HtmlMethodAttribute() : base("method", "Method", null, false, false) 
        {
        }

        public HtmlMethodAttribute(string value) : base("method", "Method", value, false, false) 
        {
        }
    }
}
