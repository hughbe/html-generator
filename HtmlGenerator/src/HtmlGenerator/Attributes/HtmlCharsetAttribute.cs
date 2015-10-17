namespace HtmlGenerator
{
    public class HtmlCharsetAttribute : HtmlAttribute 
    {
        internal HtmlCharsetAttribute() : base("charset", "Charset", null, false, false) 
        {
        }

        internal HtmlCharsetAttribute(string value) : base("charset", "Charset", value, false, false) 
        {
        }
    }
}
