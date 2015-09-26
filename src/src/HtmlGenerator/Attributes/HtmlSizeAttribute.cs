namespace HtmlGenerator
{
    public class HtmlSizeAttribute : HtmlAttribute 
    {
        public HtmlSizeAttribute() : base("size", "Size", null, false, false) 
        {
        }

        public HtmlSizeAttribute(string value) : base("size", "Size", value, false, false) 
        {
        }
    }
}
