namespace HtmlGenerator
{
    public class HtmlFormAttribute : HtmlAttribute 
    {
        internal HtmlFormAttribute() : base("form", "Form", null, false, false) 
        {
        }

        internal HtmlFormAttribute(string value) : base("form", "Form", value, false, false) 
        {
        }
    }
}
