namespace HtmlGenerator
{
    public class HtmlLangAttribute : HtmlAttribute 
    {
        public HtmlLangAttribute() : base("lang", "Lang", null, false, true) 
        {
        }

        public HtmlLangAttribute(string value) : base("lang", "Lang", value, false, true) 
        {
        }
    }
}
