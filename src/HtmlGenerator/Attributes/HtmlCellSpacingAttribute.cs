namespace HtmlGenerator.Attributes
{
    public class HtmlCellSpacingAttribute : HtmlAttribute
    {
        public HtmlCellSpacingAttribute() : base("cellspacing", "Cellspacing", null, false, false)
        {
        }

        public HtmlCellSpacingAttribute(string value) : base("cellspacing", "Cellspacing", value, false, false)
        {
        }
    }
}