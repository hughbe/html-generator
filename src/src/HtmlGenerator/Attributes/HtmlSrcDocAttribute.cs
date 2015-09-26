namespace HtmlGenerator
{
    public class HtmlSrcDocAttribute : HtmlAttribute 
    {
        public HtmlSrcDocAttribute() : base("srcdoc", "SrcDoc", null, false, false) 
        {
        }

        public HtmlSrcDocAttribute(string value) : base("srcdoc", "SrcDoc", value, false, false) 
        {
        }
    }
}
