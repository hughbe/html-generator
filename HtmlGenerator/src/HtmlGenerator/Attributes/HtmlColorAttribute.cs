namespace HtmlGenerator
{
    public class HtmlColorAttribute : HtmlAttribute 
    {
        internal HtmlColorAttribute() : base("color", "Color", null, false, false) 
        {
        }

        internal HtmlColorAttribute(string value) : base("color", "Color", value, false, false) 
        {
        }
    }
}
