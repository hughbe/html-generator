namespace HtmlGenerator
{
    public class HtmlContextMenuAttribute : HtmlAttribute 
    {
        internal HtmlContextMenuAttribute() : base("contextMenu", "ContextMenu", null, false) 
        {
        }

        internal HtmlContextMenuAttribute(string value) : base("contextMenu", "ContextMenu", value, false) 
        {
        }
    }
}
