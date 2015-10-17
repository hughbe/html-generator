namespace HtmlGenerator
{
    public class HtmlFormActionAttribute : HtmlAttribute 
    {
        internal HtmlFormActionAttribute() : base("formaction", "FormAction", null, false, false) 
        {
        }

        internal HtmlFormActionAttribute(string value) : base("formaction", "FormAction", value, false, false) 
        {
        }
    }
}
