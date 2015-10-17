namespace HtmlGenerator
{
    public class HtmlStepAttribute : HtmlAttribute 
    {
        internal HtmlStepAttribute() : base("step", "Step", null, false, false) 
        {
        }

        internal HtmlStepAttribute(string value) : base("step", "Step", value, false, false) 
        {
        }
    }
}
