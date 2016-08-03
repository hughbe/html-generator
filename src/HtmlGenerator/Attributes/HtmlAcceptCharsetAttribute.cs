namespace HtmlGenerator
{
    public class HtmlAcceptCharsetAttribute : HtmlAttribute 
    {
        public HtmlAcceptCharsetAttribute() : base("accept-charset", "AcceptCharset", null, false, false) 
        {
        }

        public HtmlAcceptCharsetAttribute(string value) : base("accept-charset", "AcceptCharset", value, false, false) 
        {
        }
    }
}
