namespace HtmlGenerator
{
    public class HtmlFormNoValidateAttribute : HtmlAttribute 
    {
        public HtmlFormNoValidateAttribute() : base("formnovalidate", "FormNoValidate", null, true, false) 
        {
        }
    }
}
