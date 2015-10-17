namespace HtmlGenerator
{
    public class HtmlRowsAttribute : HtmlAttribute 
    {
        public HtmlRowsAttribute() : base("rows", "Rows", null, false, false) 
        {
        }

        public HtmlRowsAttribute(string value) : base("rows", "Rows", value, false, false) 
        {
        }
    }
}
