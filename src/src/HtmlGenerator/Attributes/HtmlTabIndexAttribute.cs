namespace HtmlGenerator
{
    public class HtmlTabIndexAttribute : HtmlAttribute 
    {
        public HtmlTabIndexAttribute() : base("tabIndex", "TabIndex", null, false, true) 
        {
        }

        public HtmlTabIndexAttribute(string value) : base("tabIndex", "TabIndex", value, false, true) 
        {
        }
    }
}
