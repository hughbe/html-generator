namespace HtmlGenerator
{
    public class HtmlHiddenAttribute : HtmlAttribute 
    {
        internal HtmlHiddenAttribute() : base("hidden", "Hidden", null, false) 
        {
        }

        internal HtmlHiddenAttribute(string value) : base("hidden", "Hidden", value, false) 
        {
        }
    }
}
