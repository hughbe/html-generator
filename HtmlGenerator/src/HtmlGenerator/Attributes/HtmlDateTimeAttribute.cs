namespace HtmlGenerator
{
    public class HtmlDateTimeAttribute : HtmlAttribute 
    {
        public HtmlDateTimeAttribute() : base("datetime", "DateTime", null, false, false) 
        {
        }

        public HtmlDateTimeAttribute(string value) : base("datetime", "DateTime", value, false, false) 
        {
        }
    }
}
