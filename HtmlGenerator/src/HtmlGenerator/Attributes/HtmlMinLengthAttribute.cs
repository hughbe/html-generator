namespace HtmlGenerator
{
    public class HtmlMinLengthAttribute : HtmlAttribute 
    {
        internal HtmlMinLengthAttribute() : base("minLength", "MinLength", null, false, false) 
        {
        }

        internal HtmlMinLengthAttribute(string value) : base("minLength", "MinLength", value, false, false) 
        {
        }
    }
}