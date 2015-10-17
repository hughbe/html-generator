namespace HtmlGenerator
{
    public class HtmlWrapAttribute : HtmlAttribute 
    {
        public HtmlWrapAttribute() : base("wrap", "Wrap", null, false, false) 
        {
        }

        public HtmlWrapAttribute(string value) : base("wrap", "Wrap", value, false, false) 
        {
        }
    }
}
