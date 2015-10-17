namespace HtmlGenerator
{
    public class HtmlSrcDocAttribute : HtmlAttribute 
    {
        internal HtmlSrcDocAttribute() : base("srcdoc", "SrcDoc", null, false, false) 
        {
        }

        internal HtmlSrcDocAttribute(string value) : base("srcdoc", "SrcDoc", value, false, false) 
        {
        }
    }
}
