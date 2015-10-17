namespace HtmlGenerator
{
    public class HtmlPreloadAttribute : HtmlAttribute 
    {
        public HtmlPreloadAttribute() : base("preload", "Preload", null, false, false) 
        {
        }

        public HtmlPreloadAttribute(string value) : base("preload", "Preload", value, false, false) 
        {
        }
    }
}
