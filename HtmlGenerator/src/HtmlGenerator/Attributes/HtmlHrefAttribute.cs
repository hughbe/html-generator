namespace HtmlGenerator
{
    public class HtmlHrefAttribute : HtmlAttribute 
    {
        public HtmlHrefAttribute() : base("href", "Href", null, false, false) 
        {
        }

        public HtmlHrefAttribute(string value) : base("href", "Href", value, false, false) 
        {
        }
    }
}
