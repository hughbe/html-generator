namespace HtmlGenerator
{
    public class HtmlColorAttribute : HtmlAttribute 
    {
        public HtmlColorAttribute() : base("color", "Color", null, false, false) 
        {
        }

        public HtmlColorAttribute(string value) : base("color", "Color", value, false, false) 
        {
        }
    }
}
