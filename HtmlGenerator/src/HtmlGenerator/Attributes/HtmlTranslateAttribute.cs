namespace HtmlGenerator
{
    public class HtmlTranslateAttribute : HtmlAttribute 
    {
        internal HtmlTranslateAttribute() : base("translate", "Translate", null, false, true) 
        {
        }

        internal HtmlTranslateAttribute(string value) : base("translate", "Translate", value, false, true) 
        {
        }
    }
}
