namespace HtmlGenerator
{
    public class HtmlMaxLengthAttribute : HtmlAttribute 
    {
        public HtmlMaxLengthAttribute() : base("maxLength", "MaxLength", null, false, false) 
        {
        }

        public HtmlMaxLengthAttribute(string value) : base("maxLength", "MaxLength", value, false, false) 
        {
        }
    }
}
