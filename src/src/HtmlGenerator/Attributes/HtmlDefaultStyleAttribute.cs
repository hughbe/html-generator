namespace HtmlGenerator
{
    public class HtmlDefaultStyleAttribute : HtmlAttribute 
    {
        public HtmlDefaultStyleAttribute() : base("default-style", "DefaultStyle", null, false, false) 
        {
        }

        public HtmlDefaultStyleAttribute(string value) : base("default-style", "DefaultStyle", value, false, false) 
        {
        }
    }
}
