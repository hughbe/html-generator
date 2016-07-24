namespace HtmlGenerator
{
    public class HtmlWidthAttribute : HtmlAttribute 
    {
        public HtmlWidthAttribute() : base("width", "Width", null, false, false) 
        {
        }

        public HtmlWidthAttribute(string value) : base("width", "Width", value, false, false) 
        {
        }
    }
}
