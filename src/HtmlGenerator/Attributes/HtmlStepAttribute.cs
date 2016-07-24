namespace HtmlGenerator
{
    public class HtmlStepAttribute : HtmlAttribute 
    {
        public HtmlStepAttribute() : base("step", "Step", null, false, false) 
        {
        }

        public HtmlStepAttribute(string value) : base("step", "Step", value, false, false) 
        {
        }
    }
}
