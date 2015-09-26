namespace HtmlGenerator
{
    public class HtmlActionAttribute : HtmlAttribute 
    {
        public HtmlActionAttribute() : base("action", "Action", null, false, false) 
        {
        }

        public HtmlActionAttribute(string value) : base("action", "Action", value, false, false) 
        {
        }
    }
}
