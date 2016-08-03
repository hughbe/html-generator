namespace HtmlGenerator
{
    public class HtmlAccessKeyAttribute : HtmlAttribute 
    {
        public HtmlAccessKeyAttribute() : base("accesskey", "AccessKey", null, false, true) 
        {
        }

        public HtmlAccessKeyAttribute(string value) : base("accesskey", "AccessKey", value, false, true) 
        {
        }
    }
}
