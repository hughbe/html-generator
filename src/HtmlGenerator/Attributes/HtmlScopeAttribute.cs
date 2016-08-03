namespace HtmlGenerator
{
    public class HtmlScopeAttribute : HtmlAttribute 
    {
        public HtmlScopeAttribute() : base("scope", "Scope", null, false, false) 
        {
        }

        public HtmlScopeAttribute(string value) : base("scope", "Scope", value, false, false) 
        {
        }
    }
}
