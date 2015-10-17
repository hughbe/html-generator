namespace HtmlGenerator
{
    public class HtmlStartAttribute : HtmlAttribute 
    {
        internal HtmlStartAttribute() : base("start", "Start", null, false) 
        {
        }

        internal HtmlStartAttribute(string value) : base("start", "Start", value, false) 
        {
        }
    }
}
