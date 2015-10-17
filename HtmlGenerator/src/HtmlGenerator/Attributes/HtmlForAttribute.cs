namespace HtmlGenerator
{
    public class HtmlForAttribute : HtmlAttribute 
    {
        public HtmlForAttribute() : base("for", "For", null, false, false) 
        {
        }

        public HtmlForAttribute(string value) : base("for", "For", value, false, false) 
        {
        }
    }
}
