namespace HtmlGenerator
{
    public class HtmlDisabledAttribute : HtmlAttribute 
    {
        public HtmlDisabledAttribute() : base("disabled", "Disabled", null, true, false) 
        {
        }
    }
}
