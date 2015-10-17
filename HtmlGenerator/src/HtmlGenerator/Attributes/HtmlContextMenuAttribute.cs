namespace HtmlGenerator
{
    public class HtmlContextMenuAttribute : HtmlAttribute 
    {
        internal HtmlContextMenuAttribute() : base("contextMenu", "ContextMenu", null, false, false) 
        {
        }

        internal HtmlContextMenuAttribute(string value) : base("contextMenu", "ContextMenu", value, false, false) 
        {
        }
    }
}
