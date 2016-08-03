namespace HtmlGenerator
{
    public class HtmlListAttribute : HtmlAttribute 
    {
        public HtmlListAttribute() : base("list", "List", null, false, false) 
        {
        }

        public HtmlListAttribute(string value) : base("list", "List", value, false, false) 
        {
        }
    }
}
