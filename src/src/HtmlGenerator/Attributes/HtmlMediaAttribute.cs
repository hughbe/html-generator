namespace HtmlGenerator
{
    public class HtmlMediaAttribute : HtmlAttribute 
    {
        public HtmlMediaAttribute() : base("media", "Media", null, false, false) 
        {
        }

        public HtmlMediaAttribute(string value) : base("media", "Media", value, false, false) 
        {
        }
    }
}
