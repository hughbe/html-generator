namespace HtmlGenerator
{
    public class HtmlFormActionAttribute : HtmlAttribute 
    {
        public HtmlFormActionAttribute() : base("formaction", "FormAction", null, false, false) 
        {
        }

        public HtmlFormActionAttribute(string value) : base("formaction", "FormAction", value, false, false) 
        {
        }
    }
}
