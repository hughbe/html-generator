namespace HtmlGenerator.Attributes
{
    public class HtmlBgColorAttribute : HtmlAttribute
    {
        public HtmlBgColorAttribute() : base("bgcolor", "Bgcolor", null, false, false)
        {
        }

        public HtmlBgColorAttribute(string value) : base("bgcolor", "Bgcolor", value, false, false)
        {
        }
    }
}