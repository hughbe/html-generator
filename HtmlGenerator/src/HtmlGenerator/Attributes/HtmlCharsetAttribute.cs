namespace HtmlGenerator
{
    public class HtmlCharsetAttribute : HtmlAttribute 
    {
        public HtmlCharsetAttribute() : base("charset", "Charset", null, false, false) 
        {
        }

        public HtmlCharsetAttribute(string value) : base("charset", "Charset", value, false, false) 
        {
        }
    }
}
