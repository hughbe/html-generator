namespace HtmlGenerator
{
    public class HtmlColsAttribute : HtmlAttribute 
    {
        public HtmlColsAttribute() : base("cols", "Cols", null, false, false) 
        {
        }

        public HtmlColsAttribute(string value) : base("cols", "Cols", value, false, false) 
        {
        }
    }
}
