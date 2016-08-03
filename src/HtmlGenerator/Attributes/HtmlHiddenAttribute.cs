namespace HtmlGenerator
{
    public class HtmlHiddenAttribute : HtmlAttribute 
    {
        public HtmlHiddenAttribute() : base("hidden", "Hidden", null, false, true) 
        {
        }

        public HtmlHiddenAttribute(string value) : base("hidden", "Hidden", value, false, true) 
        {
        }
    }
}
