namespace HtmlGenerator
{
    public class HtmlNoValidateAttribute : HtmlAttribute 
    {
        public HtmlNoValidateAttribute() : base("novalidate", "NoValidate", null, true, false) 
        {
        }
    }
}
