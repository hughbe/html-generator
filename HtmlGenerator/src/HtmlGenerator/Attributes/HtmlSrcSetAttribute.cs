namespace HtmlGenerator
{
    public class HtmlSrcSetAttribute : HtmlAttribute 
    {
        internal HtmlSrcSetAttribute() : base("srcset", "SrcSet", null, false, false) 
        {
        }

        internal HtmlSrcSetAttribute(string value) : base("srcset", "SrcSet", value, false, false) 
        {
        }
    }
}
