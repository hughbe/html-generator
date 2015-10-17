namespace HtmlGenerator
{
    public class HtmlRadioGroupAttribute : HtmlAttribute 
    {
        internal HtmlRadioGroupAttribute() : base("radiogroup", "RadioGroup", null, false) 
        {
        }

        internal HtmlRadioGroupAttribute(string value) : base("radiogroup", "RadioGroup", value, false) 
        {
        }
    }
}
