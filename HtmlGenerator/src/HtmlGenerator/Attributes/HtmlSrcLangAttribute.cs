namespace HtmlGenerator
{
    public class HtmlSrcLangAttribute : HtmlAttribute 
    {
        internal HtmlSrcLangAttribute() : base("srclang", "SrcLang", null, false) 
        {
        }

        internal HtmlSrcLangAttribute(string value) : base("srclang", "SrcLang", value, false) 
        {
        }
    }
}
