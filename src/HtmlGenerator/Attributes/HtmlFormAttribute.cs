namespace HtmlGenerator
{
    public class HtmlFormAttribute : HtmlAttribute 
    {
        public HtmlFormAttribute() : base("form", "Form", null, false, false) 
        {
        }

        public HtmlFormAttribute(string value) : base("form", "Form", value, false, false) 
        {
        }
    }
}
