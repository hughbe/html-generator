namespace HtmlGenerator.Attributes
{
    public class HtmlCellPaddingAttribute : HtmlAttribute
    {
        public HtmlCellPaddingAttribute() : base("cellpadding", "Cellpadding", null, false, false)
        {
        }

        public HtmlCellPaddingAttribute(string value) : base("cellpadding", "Cellpadding", value, false, false)
        {
        }
    }
}