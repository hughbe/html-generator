namespace HtmlGenerator
{
    public class HtmlAsyncAttribute : HtmlAttribute 
    {
        public HtmlAsyncAttribute() : base("async", "Async", null, false, false) 
        {
        }

        public HtmlAsyncAttribute(string value) : base("async", "Async", value, false, false) 
        {
        }
    }
}
