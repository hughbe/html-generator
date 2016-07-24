namespace HtmlGenerator
{
    public class HtmlLowAttribute : HtmlAttribute 
    {
        public HtmlLowAttribute() : base("low", "Low", null, false, false) 
        {
        }

        public HtmlLowAttribute(string value) : base("low", "Low", value, false, false) 
        {
        }
    }
}
