namespace HtmlGenerator
{
    public class HtmlAsyncAttribute : HtmlAttribute 
    {
        internal HtmlAsyncAttribute() : base("async", "Async", null, false, false) 
        {
        }

        internal HtmlAsyncAttribute(string value) : base("async", "Async", value, false, false) 
        {
        }
    }
}
