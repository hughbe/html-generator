namespace HtmlGenerator
{
    public class HtmlLabelAttribute : HtmlAttribute 
    {
        public HtmlLabelAttribute() : base("label", "Label", null, false, false) 
        {
        }

        public HtmlLabelAttribute(string value) : base("label", "Label", value, false, false) 
        {
        }
    }
}
