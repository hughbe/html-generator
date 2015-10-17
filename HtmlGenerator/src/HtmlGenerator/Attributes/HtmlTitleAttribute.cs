namespace HtmlGenerator
{
    public class HtmlTitleAttribute : HtmlAttribute 
    {
        internal HtmlTitleAttribute() : base("title", "Title", null, false) 
        {
        }

        internal HtmlTitleAttribute(string value) : base("title", "Title", value, false) 
        {
        }
    }
}
