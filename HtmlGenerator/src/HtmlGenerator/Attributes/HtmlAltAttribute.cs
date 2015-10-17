namespace HtmlGenerator
{
    public class HtmlAltAttribute : HtmlAttribute 
    {
        internal HtmlAltAttribute() : base("alt", "Alt", null, false, false) 
        {
        }

        internal HtmlAltAttribute(string value) : base("alt", "Alt", value, false, false) 
        {
        }
    }
}
