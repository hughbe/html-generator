namespace HtmlGenerator
{
    public class HtmlMediaAttribute : HtmlAttribute 
    {
        internal HtmlMediaAttribute() : base("media", "Media", null, false) 
        {
        }

        internal HtmlMediaAttribute(string value) : base("media", "Media", value, false) 
        {
        }
    }
}
