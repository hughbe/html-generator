namespace HtmlGenerator
{
    public class HtmlTextAttribute : HtmlAttribute 
    {
        internal HtmlTextAttribute() : base("text", "Text", null, false, false) 
        {
        }

        internal HtmlTextAttribute(string value) : base("text", "Text", value, false, false) 
        {
        }
    }
}
