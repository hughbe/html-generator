namespace HtmlGenerator
{
    public class HtmlStartAttribute : HtmlAttribute 
    {
        public HtmlStartAttribute() : base("start", "Start", null, false, false) 
        {
        }

        public HtmlStartAttribute(string value) : base("start", "Start", value, false, false) 
        {
        }
    }
}
