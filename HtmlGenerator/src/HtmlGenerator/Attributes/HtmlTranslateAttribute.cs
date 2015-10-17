namespace HtmlGenerator
{
    public class HtmlTranslateAttribute : HtmlAttribute 
    {
        internal HtmlTranslateAttribute() : base("translate", "Translate", null, false) 
        {
        }

        internal HtmlTranslateAttribute(string value) : base("translate", "Translate", value, false) 
        {
        }
    }
}
