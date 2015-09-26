namespace HtmlGenerator
{
    public class HtmlCommandAttribute : HtmlAttribute 
    {
        public HtmlCommandAttribute() : base("command", "Command", null, false, false) 
        {
        }

        public HtmlCommandAttribute(string value) : base("command", "Command", value, false, false) 
        {
        }
    }
}
