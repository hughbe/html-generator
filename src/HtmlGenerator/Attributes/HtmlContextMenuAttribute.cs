namespace HtmlGenerator
{
    public class HtmlContextMenuAttribute : HtmlAttribute 
    {
        public HtmlContextMenuAttribute() : base("contextMenu", "ContextMenu", null, false, false) 
        {
        }

        public HtmlContextMenuAttribute(string value) : base("contextMenu", "ContextMenu", value, false, false) 
        {
        }
    }
}
