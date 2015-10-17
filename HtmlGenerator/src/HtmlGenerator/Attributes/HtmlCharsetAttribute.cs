namespace HtmlGenerator
{
    public class HtmlCharsetAttribute : HtmlAttribute 
    {
        internal HtmlCharsetAttribute() : base("charset", "Charset", null, false) 
        {
        }

        internal HtmlCharsetAttribute(string value) : base("charset", "Charset", value, false) 
        {
        }
    }
}
