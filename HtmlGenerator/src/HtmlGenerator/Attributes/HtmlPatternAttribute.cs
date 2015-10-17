namespace HtmlGenerator
{
    public class HtmlPatternAttribute : HtmlAttribute 
    {
        internal HtmlPatternAttribute() : base("pattern", "Pattern", null, false, false) 
        {
        }

        internal HtmlPatternAttribute(string value) : base("pattern", "Pattern", value, false, false) 
        {
        }
    }
}
