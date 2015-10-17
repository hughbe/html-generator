namespace HtmlGenerator
{
    public class HtmlWidthAttribute : HtmlAttribute 
    {
        internal HtmlWidthAttribute() : base("width", "Width", null, false) 
        {
        }

        internal HtmlWidthAttribute(string value) : base("width", "Width", value, false) 
        {
        }
    }
}
