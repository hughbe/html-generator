namespace HtmlGenerator
{
    public class HtmlHrefAttribute : HtmlAttribute 
    {
        internal HtmlHrefAttribute() : base("href", "Href", null, false, false) 
        {
        }

        internal HtmlHrefAttribute(string value) : base("href", "Href", value, false, false) 
        {
        }
    }
}
