namespace HtmlGenerator
{
    public class HtmlHighAttribute : HtmlAttribute 
    {
        public HtmlHighAttribute() : base("high", "High", null, false, false) 
        {
        }

        public HtmlHighAttribute(string value) : base("high", "High", value, false, false) 
        {
        }
    }
}
