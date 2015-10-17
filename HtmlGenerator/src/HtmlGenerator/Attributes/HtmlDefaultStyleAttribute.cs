namespace HtmlGenerator
{
    public class HtmlDefaultStyleAttribute : HtmlAttribute 
    {
        internal HtmlDefaultStyleAttribute() : base("default-style", "DefaultStyle", null, false, false) 
        {
        }

        internal HtmlDefaultStyleAttribute(string value) : base("default-style", "DefaultStyle", value, false, false) 
        {
        }
    }
}
