namespace HtmlGenerator
{
    public class HtmlAutoPlayAttribute : HtmlAttribute 
    {
        public HtmlAutoPlayAttribute() : base("autoplay", "AutoPlay", null, false, false) 
        {
        }

        public HtmlAutoPlayAttribute(string value) : base("autoplay", "AutoPlay", value, false, false) 
        {
        }
    }
}
