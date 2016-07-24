namespace HtmlGenerator
{
    public class HtmlOpenAttribute : HtmlAttribute 
    {
        public HtmlOpenAttribute() : base("open", "Open", null, false, false) 
        {
        }

        public HtmlOpenAttribute(string value) : base("open", "Open", value, false, false) 
        {
        }
    }
}
