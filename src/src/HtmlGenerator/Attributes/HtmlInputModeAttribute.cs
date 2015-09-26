namespace HtmlGenerator
{
    public class HtmlInputModeAttribute : HtmlAttribute 
    {
        public HtmlInputModeAttribute() : base("inputmode", "InputMode", null, false, false) 
        {
        }

        public HtmlInputModeAttribute(string value) : base("inputmode", "InputMode", value, false, false) 
        {
        }
    }
}
