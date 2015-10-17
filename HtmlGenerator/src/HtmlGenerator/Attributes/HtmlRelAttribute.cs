namespace HtmlGenerator
{
    public class HtmlRelAttribute : HtmlAttribute 
    {
        internal HtmlRelAttribute() : base("rel", "Rel", null, false) 
        {
        }

        internal HtmlRelAttribute(string value) : base("rel", "Rel", value, false) 
        {
        }
    }
}
