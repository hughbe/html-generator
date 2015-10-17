namespace HtmlGenerator
{
    public class HtmlPlaceholderAttribute : HtmlAttribute 
    {
        internal HtmlPlaceholderAttribute() : base("placeholder", "Placeholder", null, false, false) 
        {
        }

        internal HtmlPlaceholderAttribute(string value) : base("placeholder", "Placeholder", value, false, false) 
        {
        }
    }
}
