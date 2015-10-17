namespace HtmlGenerator
{
    public class HtmlMinAttribute : HtmlAttribute 
    {
        internal HtmlMinAttribute() : base("min", "Min", null, false) 
        {
        }

        internal HtmlMinAttribute(string value) : base("min", "Min", value, false) 
        {
        }
    }
}
