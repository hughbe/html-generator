namespace HtmlGenerator
{
    public class HtmlRowSpanAttribute : HtmlAttribute 
    {
        public HtmlRowSpanAttribute() : base("rowspan", "RowSpan", null, false, false) 
        {
        }

        public HtmlRowSpanAttribute(string value) : base("rowspan", "RowSpan", value, false, false) 
        {
        }
    }
}
