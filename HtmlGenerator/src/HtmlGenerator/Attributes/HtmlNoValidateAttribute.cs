namespace HtmlGenerator
{
    public class HtmlNoValidateAttribute : HtmlAttribute 
    {
        internal HtmlNoValidateAttribute() : base("novalidate", "NoValidate", null, true) 
        {
        }
    }
}
