namespace HtmlGenerator.Attributes
{
    public class HtmlBorderAttribute : HtmlAttribute
    {
        public HtmlBorderAttribute() : base("border", "Border", null, false, false)
        {
        }

        public HtmlBorderAttribute(string value) : base("border", "Border", value, false, false)
        {
        }
    }
}