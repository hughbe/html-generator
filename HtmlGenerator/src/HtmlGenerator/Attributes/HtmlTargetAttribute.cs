namespace HtmlGenerator
{
    public class HtmlTargetAttribute : HtmlAttribute 
    {
        internal HtmlTargetAttribute() : base("target", "Target", null, false) 
        {
        }

        internal HtmlTargetAttribute(string value) : base("target", "Target", value, false) 
        {
        }
    }
}
