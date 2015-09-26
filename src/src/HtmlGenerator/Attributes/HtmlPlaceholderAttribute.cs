namespace HtmlGenerator
{
    public class HtmlPlaceholderAttribute : HtmlAttribute 
    {
        public HtmlPlaceholderAttribute() : base("placeholder", "Placeholder", null, false, false) 
        {
        }

        public HtmlPlaceholderAttribute(string value) : base("placeholder", "Placeholder", value, false, false) 
        {
        }
    }
}
