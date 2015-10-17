namespace HtmlGenerator
{
    public class HtmlCoordsAttribute : HtmlAttribute 
    {
        internal HtmlCoordsAttribute() : base("coords", "Coords", null, false, false) 
        {
        }

        internal HtmlCoordsAttribute(string value) : base("coords", "Coords", value, false, false) 
        {
        }
    }
}
