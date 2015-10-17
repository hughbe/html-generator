namespace HtmlGenerator
{
    public class HtmlDateTimeAttribute : HtmlAttribute 
    {
        internal HtmlDateTimeAttribute() : base("datetime", "DateTime", null, false) 
        {
        }

        internal HtmlDateTimeAttribute(string value) : base("datetime", "DateTime", value, false) 
        {
        }
    }
}
