namespace HtmlGenerator
{
    public class HtmlSrcAttribute : HtmlAttribute 
    {
        public HtmlSrcAttribute() : base("src", "Src", null, false, false) 
        {
        }

        public HtmlSrcAttribute(string value) : base("src", "Src", value, false, false) 
        {
        }
    }
}
