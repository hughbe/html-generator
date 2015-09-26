namespace HtmlGenerator
{
    public class HtmlTargetAttribute : HtmlAttribute 
    {
        public HtmlTargetAttribute() : base("target", "Target", null, false, false) 
        {
        }

        public HtmlTargetAttribute(string value) : base("target", "Target", value, false, false) 
        {
        }
    }
}
