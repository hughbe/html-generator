namespace HtmlGenerator
{
    public class HtmlNoWrapAttribute : HtmlAttribute 
    {
        public HtmlNoWrapAttribute() : base("nowrap", "NoWrap", null, false, false) 
        {
        }

        public HtmlNoWrapAttribute(string value) : base("nowrap", "NoWrap", value, false, false) 
        {
        }
    }
}
