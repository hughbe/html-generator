namespace HtmlGenerator
{
    public class HtmlFormTargetAttribute : HtmlAttribute 
    {
        public HtmlFormTargetAttribute() : base("formtarget", "FormTarget", null, false, false) 
        {
        }

        public HtmlFormTargetAttribute(string value) : base("formtarget", "FormTarget", value, false, false) 
        {
        }
    }
}
