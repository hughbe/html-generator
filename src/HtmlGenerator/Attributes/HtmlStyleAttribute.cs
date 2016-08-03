namespace HtmlGenerator
{
    public class HtmlStyleAttribute : HtmlAttribute 
    {
        public HtmlStyleAttribute() : base("style", "Style", null, false, false) 
        {
        }

        public HtmlStyleAttribute(string value) : base("style", "Style", value, false, false) 
        {
        }
    }
}
