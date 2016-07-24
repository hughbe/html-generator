namespace HtmlGenerator
{
    public class HtmlUseMapAttribute : HtmlAttribute 
    {
        public HtmlUseMapAttribute() : base("usemap", "UseMap", null, false, false) 
        {
        }

        public HtmlUseMapAttribute(string value) : base("usemap", "UseMap", value, false, false) 
        {
        }
    }
}
