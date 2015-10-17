namespace HtmlGenerator
{
    public class HtmlLabelAttribute : HtmlAttribute 
    {
        internal HtmlLabelAttribute() : base("label", "Label", null, false, false) 
        {
        }

        internal HtmlLabelAttribute(string value) : base("label", "Label", value, false, false) 
        {
        }
    }
}
