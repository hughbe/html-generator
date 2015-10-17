namespace HtmlGenerator
{
    public class HtmlContentAttribute : HtmlAttribute 
    {
        internal HtmlContentAttribute() : base("content", "Content", null, false, false) 
        {
        }

        internal HtmlContentAttribute(string value) : base("content", "Content", value, false, false) 
        {
        }
    }
}
