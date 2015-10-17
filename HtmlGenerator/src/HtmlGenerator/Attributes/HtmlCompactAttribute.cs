namespace HtmlGenerator
{
    public class HtmlCompactAttribute : HtmlAttribute 
    {
        internal HtmlCompactAttribute() : base("compact", "Compact", null, false, false) 
        {
        }

        internal HtmlCompactAttribute(string value) : base("compact", "Compact", value, false, false) 
        {
        }
    }
}
