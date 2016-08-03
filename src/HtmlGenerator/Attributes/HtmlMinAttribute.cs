namespace HtmlGenerator
{
    public class HtmlMinAttribute : HtmlAttribute 
    {
        public HtmlMinAttribute() : base("min", "Min", null, false, false) 
        {
        }

        public HtmlMinAttribute(string value) : base("min", "Min", value, false, false) 
        {
        }
    }
}
