namespace HtmlGenerator
{
    public class HtmlTextAttribute : HtmlAttribute 
    {
        public HtmlTextAttribute() : base("text", "Text", null, false, false) 
        {
        }

        public HtmlTextAttribute(string value) : base("text", "Text", value, false, false) 
        {
        }
    }
}
