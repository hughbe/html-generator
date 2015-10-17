namespace HtmlGenerator
{
    public class HtmlReversedAttribute : HtmlAttribute 
    {
        internal HtmlReversedAttribute() : base("reversed", "Reversed", null, false) 
        {
        }

        internal HtmlReversedAttribute(string value) : base("reversed", "Reversed", value, false) 
        {
        }
    }
}
