namespace HtmlGenerator
{
    public class HtmlPatternAttribute : HtmlAttribute 
    {
        public HtmlPatternAttribute() : base("pattern", "Pattern", null, false, false) 
        {
        }

        public HtmlPatternAttribute(string value) : base("pattern", "Pattern", value, false, false) 
        {
        }
    }
}
