namespace HtmlGenerator
{
    public class HtmlMutedAttribute : HtmlAttribute 
    {
        internal HtmlMutedAttribute() : base("muted", "Muted", null, false, false) 
        {
        }

        internal HtmlMutedAttribute(string value) : base("muted", "Muted", value, false, false) 
        {
        }
    }
}
