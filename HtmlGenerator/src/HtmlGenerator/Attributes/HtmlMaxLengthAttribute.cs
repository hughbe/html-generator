namespace HtmlGenerator
{
    public class HtmlMaxLengthAttribute : HtmlAttribute 
    {
        internal HtmlMaxLengthAttribute() : base("maxLength", "MaxLength", null, false, false) 
        {
        }

        internal HtmlMaxLengthAttribute(string value) : base("maxLength", "MaxLength", value, false, false) 
        {
        }
    }
}
