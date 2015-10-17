namespace HtmlGenerator
{
    public class HtmlDraggableAttribute : HtmlAttribute 
    {
        public HtmlDraggableAttribute() : base("draggable", "Draggable", null, false, false) 
        {
        }

        public HtmlDraggableAttribute(string value) : base("draggable", "Draggable", value, false, false) 
        {
        }
    }
}
