namespace HtmlGenerator
{
    public class HtmlFormAttribute : HtmlAttribute 
    {
        internal HtmlFormAttribute() : base("form", "Form", null, false) 
        {
        }

        internal HtmlFormAttribute(string value) : base("form", "Form", value, false) 
        {
        }
    }
}
