namespace HtmlGenerator
{
    public class HtmlShapeAttribute : HtmlAttribute 
    {
        public HtmlShapeAttribute() : base("shape", "Shape", null, false, false) 
        {
        }

        public HtmlShapeAttribute(string value) : base("shape", "Shape", value, false, false) 
        {
        }
    }
}
