namespace HtmlGenerator
{
    public class HtmlLangAttribute : HtmlAttribute 
    {
        internal HtmlLangAttribute() : base("lang", "Lang", null, false, true) 
        {
        }

        internal HtmlLangAttribute(string value) : base("lang", "Lang", value, false, true) 
        {
        }
    }
}
