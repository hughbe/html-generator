namespace HtmlGenerator
{
    public class HtmlFormNoValidateAttribute : HtmlAttribute 
    {
        internal HtmlFormNoValidateAttribute() : base("formnovalidate", "FormNoValidate", null, true) 
        {
        }
    }
}
