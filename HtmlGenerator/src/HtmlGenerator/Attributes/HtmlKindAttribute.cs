namespace HtmlGenerator
{
    public class HtmlKindAttribute : HtmlAttribute 
    {
        internal HtmlKindAttribute() : base("kind", "Kind", null, false) 
        {
        }

        internal HtmlKindAttribute(string value) : base("kind", "Kind", value, false) 
        {
        }
    }
}
