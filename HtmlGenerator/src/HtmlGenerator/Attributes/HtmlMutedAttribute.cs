namespace HtmlGenerator
{
    public class HtmlMutedAttribute : HtmlAttribute 
    {
        public HtmlMutedAttribute() : base("muted", "Muted", null, false, false) 
        {
        }

        public HtmlMutedAttribute(string value) : base("muted", "Muted", value, false, false) 
        {
        }
    }
}
