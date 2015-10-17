namespace HtmlGenerator
{
    public class HtmlPreloadAttribute : HtmlAttribute 
    {
        internal HtmlPreloadAttribute() : base("preload", "Preload", null, false) 
        {
        }

        internal HtmlPreloadAttribute(string value) : base("preload", "Preload", value, false) 
        {
        }
    }
}
