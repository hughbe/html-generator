namespace HtmlGenerator
{
    public class HtmlDeferAttribute : HtmlAttribute 
    {
        internal HtmlDeferAttribute() : base("defer", "Defer", null, false, false) 
        {
        }

        internal HtmlDeferAttribute(string value) : base("defer", "Defer", value, false, false) 
        {
        }
    }
}
