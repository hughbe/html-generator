namespace HtmlGenerator
{
    public class HtmlDisabledAttribute : HtmlAttribute 
    {
        internal HtmlDisabledAttribute() : base("disabled", "Disabled", null, true, false) 
        {
        }
    }
}
