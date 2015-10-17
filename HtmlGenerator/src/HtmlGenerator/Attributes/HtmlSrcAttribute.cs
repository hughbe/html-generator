namespace HtmlGenerator
{
    public class HtmlSrcAttribute : HtmlAttribute 
    {
        internal HtmlSrcAttribute() : base("src", "Src", null, false, false) 
        {
        }

        internal HtmlSrcAttribute(string value) : base("src", "Src", value, false, false) 
        {
        }
    }
}
