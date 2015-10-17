namespace HtmlGenerator
{
    public class HtmlFormEncTypeAttribute : HtmlAttribute 
    {
        internal HtmlFormEncTypeAttribute() : base("formenctype", "FormEncType", null, false) 
        {
        }

        internal HtmlFormEncTypeAttribute(string value) : base("formenctype", "FormEncType", value, false) 
        {
        }
    }
}
