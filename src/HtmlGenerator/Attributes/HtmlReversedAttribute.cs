namespace HtmlGenerator
{
    public class HtmlReversedAttribute : HtmlAttribute 
    {
        public HtmlReversedAttribute() : base("reversed", "Reversed", null, false, false) 
        {
        }

        public HtmlReversedAttribute(string value) : base("reversed", "Reversed", value, false, false) 
        {
        }
    }
}
