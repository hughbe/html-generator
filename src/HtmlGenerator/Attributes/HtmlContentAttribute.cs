namespace HtmlGenerator
{
    public class HtmlContentAttribute : HtmlAttribute 
    {
        public HtmlContentAttribute() : base("content", "Content", null, false, false) 
        {
        }

        public HtmlContentAttribute(string value) : base("content", "Content", value, false, false) 
        {
        }
    }
}
