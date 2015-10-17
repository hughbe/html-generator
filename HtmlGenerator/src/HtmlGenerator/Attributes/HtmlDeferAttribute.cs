namespace HtmlGenerator
{
    public class HtmlDeferAttribute : HtmlAttribute 
    {
        public HtmlDeferAttribute() : base("defer", "Defer", null, false, false) 
        {
        }

        public HtmlDeferAttribute(string value) : base("defer", "Defer", value, false, false) 
        {
        }
    }
}
