namespace HtmlGenerator
{
    public class HtmlFormActionAttribute : HtmlAttribute 
    {
        internal HtmlFormActionAttribute() : base("formaction", "FormAction", null, false) 
        {
        }

        internal HtmlFormActionAttribute(string value) : base("formaction", "FormAction", value, false) 
        {
        }
    }
}
