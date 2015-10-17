namespace HtmlGenerator
{
    public class HtmlSizeAttribute : HtmlAttribute 
    {
        internal HtmlSizeAttribute() : base("size", "Size", null, false) 
        {
        }

        internal HtmlSizeAttribute(string value) : base("size", "Size", value, false) 
        {
        }
    }
}
