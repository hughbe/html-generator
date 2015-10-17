namespace HtmlGenerator
{
    public class HtmlTitleAttribute : HtmlAttribute 
    {
        public HtmlTitleAttribute() : base("title", "Title", null, false, true) 
        {
        }

        public HtmlTitleAttribute(string value) : base("title", "Title", value, false, true) 
        {
        }
    }
}
