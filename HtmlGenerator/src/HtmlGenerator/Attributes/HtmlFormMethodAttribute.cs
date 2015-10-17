namespace HtmlGenerator
{
    public class HtmlFormMethodAttribute : HtmlAttribute 
    {
        internal HtmlFormMethodAttribute() : base("formmethod", "FormMethod", null, false, false) 
        {
        }

        internal HtmlFormMethodAttribute(string value) : base("formmethod", "FormMethod", value, false, false) 
        {
        }
    }
}
