namespace HtmlGenerator
{
    public class HtmlColSpanAttribute : HtmlAttribute 
    {
        public HtmlColSpanAttribute() : base("colspan", "ColSpan", null, false, false) 
        {
        }

        public HtmlColSpanAttribute(string value) : base("colspan", "ColSpan", value, false, false) 
        {
        }
    }
}
