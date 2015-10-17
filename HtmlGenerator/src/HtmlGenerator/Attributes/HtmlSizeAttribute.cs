namespace HtmlGenerator
{
    public class HtmlSizeAttribute : HtmlAttribute 
    {
        internal HtmlSizeAttribute() : base("size", "Size", null, false, false) 
        {
        }

        internal HtmlSizeAttribute(string value) : base("size", "Size", value, false, false) 
        {
        }
    }
}
