namespace HtmlGenerator.Attributes
{
    public class HtmlAlignAttribute : HtmlAttribute
    {
        public HtmlAlignAttribute() : base("align", "Align", null, false, false)
        {
        }

        public HtmlAlignAttribute(string value) : base("align", "Align", value, false, false)
        {
        }
    }
}