namespace HtmlGenerator
{
    public class HtmlOpenAttribute : HtmlAttribute 
    {
        internal HtmlOpenAttribute() : base("open", "Open", null, false) 
        {
        }

        internal HtmlOpenAttribute(string value) : base("open", "Open", value, false) 
        {
        }
    }
}
