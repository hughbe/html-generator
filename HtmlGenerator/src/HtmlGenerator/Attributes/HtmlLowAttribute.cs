namespace HtmlGenerator
{
    public class HtmlLowAttribute : HtmlAttribute 
    {
        internal HtmlLowAttribute() : base("low", "Low", null, false, false) 
        {
        }

        internal HtmlLowAttribute(string value) : base("low", "Low", value, false, false) 
        {
        }
    }
}
