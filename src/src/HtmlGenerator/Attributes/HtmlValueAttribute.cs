namespace HtmlGenerator
{
    public class HtmlValueAttribute : HtmlAttribute 
    {
        public HtmlValueAttribute() : base("value", "Value", null, false, false) 
        {
        }

        public HtmlValueAttribute(string value) : base("value", "Value", value, false, false) 
        {
        }
    }
}
