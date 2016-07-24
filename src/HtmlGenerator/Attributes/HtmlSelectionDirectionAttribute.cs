namespace HtmlGenerator
{
    public class HtmlSelectionDirectionAttribute : HtmlAttribute 
    {
        public HtmlSelectionDirectionAttribute() : base("selectionDirection", "SelectionDirection", null, false, false) 
        {
        }

        public HtmlSelectionDirectionAttribute(string value) : base("selectionDirection", "SelectionDirection", value, false, false) 
        {
        }
    }
}
