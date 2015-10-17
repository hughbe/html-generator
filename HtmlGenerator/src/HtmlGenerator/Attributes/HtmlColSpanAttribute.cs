namespace HtmlGenerator
{
    public class HtmlColSpanAttribute : HtmlAttribute 
    {
        internal HtmlColSpanAttribute() : base("colspan", "ColSpan", null, false) 
        {
        }

        internal HtmlColSpanAttribute(string value) : base("colspan", "ColSpan", value, false) 
        {
        }
    }
}
