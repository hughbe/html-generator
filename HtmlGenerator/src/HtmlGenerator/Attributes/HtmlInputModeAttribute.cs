namespace HtmlGenerator
{
    public class HtmlInputModeAttribute : HtmlAttribute 
    {
        internal HtmlInputModeAttribute() : base("inputmode", "InputMode", null, false, false) 
        {
        }

        internal HtmlInputModeAttribute(string value) : base("inputmode", "InputMode", value, false, false) 
        {
        }
    }
}
