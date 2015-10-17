namespace HtmlGenerator
{
    public class HtmlFormTargetAttribute : HtmlAttribute 
    {
        internal HtmlFormTargetAttribute() : base("formtarget", "FormTarget", null, false, false) 
        {
        }

        internal HtmlFormTargetAttribute(string value) : base("formtarget", "FormTarget", value, false, false) 
        {
        }
    }
}
