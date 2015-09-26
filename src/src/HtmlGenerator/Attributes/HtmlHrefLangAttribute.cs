namespace HtmlGenerator
{
    public class HtmlHrefLangAttribute : HtmlAttribute 
    {
        public HtmlHrefLangAttribute() : base("hreflang", "HrefLang", null, false, false) 
        {
        }

        public HtmlHrefLangAttribute(string value) : base("hreflang", "HrefLang", value, false, false) 
        {
        }
    }
}
