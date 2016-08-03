namespace HtmlGenerator
{
    public class HtmlMaxAttribute : HtmlAttribute 
    {
        public HtmlMaxAttribute() : base("max", "Max", null, false, false) 
        {
        }

        public HtmlMaxAttribute(string value) : base("max", "Max", value, false, false) 
        {
        }
    }
}
