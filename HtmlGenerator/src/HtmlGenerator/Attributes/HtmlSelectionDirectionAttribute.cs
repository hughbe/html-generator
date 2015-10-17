namespace HtmlGenerator
{
    public class HtmlSelectionDirectionAttribute : HtmlAttribute 
    {
        internal HtmlSelectionDirectionAttribute() : base("selectionDirection", "SelectionDirection", null, false) 
        {
        }

        internal HtmlSelectionDirectionAttribute(string value) : base("selectionDirection", "SelectionDirection", value, false) 
        {
        }
    }
}
