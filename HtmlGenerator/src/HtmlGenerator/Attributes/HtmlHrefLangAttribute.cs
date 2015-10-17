namespace HtmlGenerator
{
    public class HtmlHrefLangAttribute : HtmlAttribute 
    {
        internal HtmlHrefLangAttribute() : base("hreflang", "HrefLang", null, false, false) 
        {
        }

        internal HtmlHrefLangAttribute(string value) : base("hreflang", "HrefLang", value, false, false) 
        {
        }
    }
}
