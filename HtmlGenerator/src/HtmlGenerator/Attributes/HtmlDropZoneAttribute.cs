namespace HtmlGenerator
{
    public class HtmlDropZoneAttribute : HtmlAttribute 
    {
        internal HtmlDropZoneAttribute() : base("dropzone", "DropZone", null, false) 
        {
        }

        internal HtmlDropZoneAttribute(string value) : base("dropzone", "DropZone", value, false) 
        {
        }
    }
}
