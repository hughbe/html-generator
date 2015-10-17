namespace HtmlGenerator
{
    public class HtmlCompactAttribute : HtmlAttribute 
    {
        public HtmlCompactAttribute() : base("compact", "Compact", null, false, false) 
        {
        }

        public HtmlCompactAttribute(string value) : base("compact", "Compact", value, false, false) 
        {
        }
    }
}
