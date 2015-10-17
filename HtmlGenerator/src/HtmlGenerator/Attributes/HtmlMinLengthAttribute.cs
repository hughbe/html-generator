namespace HtmlGenerator
{
    public class HtmlMinLengthAttribute : HtmlAttribute 
    {
        public HtmlMinLengthAttribute() : base("minLength", "MinLength", null, false, false) 
        {
        }

        public HtmlMinLengthAttribute(string value) : base("minLength", "MinLength", value, false, false) 
        {
        }
    }
}
