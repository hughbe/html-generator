namespace HtmlGenerator
{
    public class HtmlCoordsAttribute : HtmlAttribute 
    {
        public HtmlCoordsAttribute() : base("coords", "Coords", null, false, false) 
        {
        }

        public HtmlCoordsAttribute(string value) : base("coords", "Coords", value, false, false) 
        {
        }
    }
}
