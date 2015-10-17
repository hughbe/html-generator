namespace HtmlGenerator
{
    public class HtmlWrapAttribute : HtmlAttribute 
    {
        internal HtmlWrapAttribute() : base("wrap", "Wrap", null, false) 
        {
        }

        internal HtmlWrapAttribute(string value) : base("wrap", "Wrap", value, false) 
        {
        }
    }
}
