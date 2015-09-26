namespace HtmlGenerator
{
    public class HtmlSrcSetAttribute : HtmlAttribute 
    {
        public HtmlSrcSetAttribute() : base("srcset", "SrcSet", null, false, false) 
        {
        }

        public HtmlSrcSetAttribute(string value) : base("srcset", "SrcSet", value, false, false) 
        {
        }
    }
}
