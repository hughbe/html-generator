namespace HtmlGenerator
{
    public class HtmlRowSpanAttribute : HtmlAttribute 
    {
        internal HtmlRowSpanAttribute() : base("rowspan", "RowSpan", null, false) 
        {
        }

        internal HtmlRowSpanAttribute(string value) : base("rowspan", "RowSpan", value, false) 
        {
        }
    }
}
