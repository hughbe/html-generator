namespace HtmlGenerator
{
    public class HtmlTitleAttribute : HtmlAttribute 
    {
        internal HtmlTitleAttribute() : base("title", "Title", null, false, true) 
        {
        }

        internal HtmlTitleAttribute(string value) : base("title", "Title", value, false, true) 
        {
        }
    }
}
