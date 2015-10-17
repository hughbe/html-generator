namespace HtmlGenerator
{
    public class HtmlNoWrapAttribute : HtmlAttribute 
    {
        internal HtmlNoWrapAttribute() : base("nowrap", "NoWrap", null, false, false) 
        {
        }

        internal HtmlNoWrapAttribute(string value) : base("nowrap", "NoWrap", value, false, false) 
        {
        }
    }
}
