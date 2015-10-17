namespace HtmlGenerator
{
    public class HtmlUseMapAttribute : HtmlAttribute 
    {
        internal HtmlUseMapAttribute() : base("usemap", "UseMap", null, false, false) 
        {
        }

        internal HtmlUseMapAttribute(string value) : base("usemap", "UseMap", value, false, false) 
        {
        }
    }
}
