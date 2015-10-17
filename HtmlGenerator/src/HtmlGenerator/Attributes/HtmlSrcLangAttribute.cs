namespace HtmlGenerator
{
    public class HtmlSrcLangAttribute : HtmlAttribute 
    {
        public HtmlSrcLangAttribute() : base("srclang", "SrcLang", null, false, false) 
        {
        }

        public HtmlSrcLangAttribute(string value) : base("srclang", "SrcLang", value, false, false) 
        {
        }
    }
}
