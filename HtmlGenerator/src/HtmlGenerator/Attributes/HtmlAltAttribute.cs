namespace HtmlGenerator
{
    public class HtmlAltAttribute : HtmlAttribute 
    {
        public HtmlAltAttribute() : base("alt", "Alt", null, false, false) 
        {
        }

        public HtmlAltAttribute(string value) : base("alt", "Alt", value, false, false) 
        {
        }
    }
}
