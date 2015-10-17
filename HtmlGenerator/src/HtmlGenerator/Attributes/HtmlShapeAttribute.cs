namespace HtmlGenerator
{
    public class HtmlShapeAttribute : HtmlAttribute 
    {
        internal HtmlShapeAttribute() : base("shape", "Shape", null, false, false) 
        {
        }

        internal HtmlShapeAttribute(string value) : base("shape", "Shape", value, false, false) 
        {
        }
    }
}
