namespace HtmlGenerator
{
    public class HtmlRowsAttribute : HtmlAttribute 
    {
        internal HtmlRowsAttribute() : base("rows", "Rows", null, false, false) 
        {
        }

        internal HtmlRowsAttribute(string value) : base("rows", "Rows", value, false, false) 
        {
        }
    }
}
