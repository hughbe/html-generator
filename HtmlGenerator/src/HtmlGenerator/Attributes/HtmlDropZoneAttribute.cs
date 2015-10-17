namespace HtmlGenerator
{
    public class HtmlDropZoneAttribute : HtmlAttribute 
    {
        public HtmlDropZoneAttribute() : base("dropzone", "DropZone", null, false, false) 
        {
        }

        public HtmlDropZoneAttribute(string value) : base("dropzone", "DropZone", value, false, false) 
        {
        }
    }
}
