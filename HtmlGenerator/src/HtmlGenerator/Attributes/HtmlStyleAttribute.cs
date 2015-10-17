namespace HtmlGenerator
{
    public class HtmlStyleAttribute : HtmlAttribute 
    {
        internal HtmlStyleAttribute() : base("style", "Style", null, false) 
        {
        }

        internal HtmlStyleAttribute(string value) : base("style", "Style", value, false) 
        {
        }
    }
}
