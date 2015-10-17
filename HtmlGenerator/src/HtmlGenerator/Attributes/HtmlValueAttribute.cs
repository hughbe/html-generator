namespace HtmlGenerator
{
    public class HtmlValueAttribute : HtmlAttribute 
    {
        internal HtmlValueAttribute() : base("value", "Value", null, false) 
        {
        }

        internal HtmlValueAttribute(string value) : base("value", "Value", value, false) 
        {
        }
    }
}
