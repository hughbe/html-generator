namespace HtmlGenerator
{
    public class HtmlAcceptCharsetAttribute : HtmlAttribute 
    {
        internal HtmlAcceptCharsetAttribute() : base("accept-charset", "AcceptCharset", null, false) 
        {
        }

        internal HtmlAcceptCharsetAttribute(string value) : base("accept-charset", "AcceptCharset", value, false) 
        {
        }
    }
}
