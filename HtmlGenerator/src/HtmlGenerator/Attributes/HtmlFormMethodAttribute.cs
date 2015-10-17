namespace HtmlGenerator
{
    public class HtmlFormMethodAttribute : HtmlAttribute 
    {
        public HtmlFormMethodAttribute() : base("formmethod", "FormMethod", null, false, false) 
        {
        }

        public HtmlFormMethodAttribute(string value) : base("formmethod", "FormMethod", value, false, false) 
        {
        }
    }
}
