namespace HtmlGenerator
{
    public class HtmlColsAttribute : HtmlAttribute 
    {
        internal HtmlColsAttribute() : base("cols", "Cols", null, false, false) 
        {
        }

        internal HtmlColsAttribute(string value) : base("cols", "Cols", value, false, false) 
        {
        }
    }
}
