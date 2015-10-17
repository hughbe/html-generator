namespace HtmlGenerator
{
    public class HtmlCommandAttribute : HtmlAttribute 
    {
        internal HtmlCommandAttribute() : base("command", "Command", null, false, false) 
        {
        }

        internal HtmlCommandAttribute(string value) : base("command", "Command", value, false, false) 
        {
        }
    }
}
