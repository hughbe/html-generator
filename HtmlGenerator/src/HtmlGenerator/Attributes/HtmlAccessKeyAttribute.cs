namespace HtmlGenerator
{
    public class HtmlAccessKeyAttribute : HtmlAttribute 
    {
        internal HtmlAccessKeyAttribute() : base("accesskey", "AccessKey", null, false) 
        {
        }

        internal HtmlAccessKeyAttribute(string value) : base("accesskey", "AccessKey", value, false) 
        {
        }
    }
}
