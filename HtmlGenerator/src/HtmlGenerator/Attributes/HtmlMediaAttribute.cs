namespace HtmlGenerator
{
    public class HtmlMediaAttribute : HtmlAttribute 
    {
        internal HtmlMediaAttribute() : base("media", "Media", null, false, false) 
        {
        }

        internal HtmlMediaAttribute(string value) : base("media", "Media", value, false, false) 
        {
        }
    }
}
