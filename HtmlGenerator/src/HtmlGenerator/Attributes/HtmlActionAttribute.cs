namespace HtmlGenerator
{
    public class HtmlActionAttribute : HtmlAttribute 
    {
        internal HtmlActionAttribute() : base("action", "Action", null, false, false) 
        {
        }

        internal HtmlActionAttribute(string value) : base("action", "Action", value, false, false) 
        {
        }
    }
}
