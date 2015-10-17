namespace HtmlGenerator
{
    public class HtmlMaxAttribute : HtmlAttribute 
    {
        internal HtmlMaxAttribute() : base("max", "Max", null, false) 
        {
        }

        internal HtmlMaxAttribute(string value) : base("max", "Max", value, false) 
        {
        }
    }
}
