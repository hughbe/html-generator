namespace HtmlGenerator
{
    public class HtmlRadioGroupAttribute : HtmlAttribute 
    {
        public HtmlRadioGroupAttribute() : base("radiogroup", "RadioGroup", null, false, false) 
        {
        }

        public HtmlRadioGroupAttribute(string value) : base("radiogroup", "RadioGroup", value, false, false) 
        {
        }
    }
}
