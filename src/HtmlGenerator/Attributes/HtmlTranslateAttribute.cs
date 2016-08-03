namespace HtmlGenerator
{
    public class HtmlTranslateAttribute : HtmlAttribute 
    {
        public HtmlTranslateAttribute() : base("translate", "Translate", null, false, true) 
        {
        }

        public HtmlTranslateAttribute(string value) : base("translate", "Translate", value, false, true) 
        {
        }
    }
}
