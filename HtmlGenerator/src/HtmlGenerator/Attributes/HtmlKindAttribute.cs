namespace HtmlGenerator
{
    public class HtmlKindAttribute : HtmlAttribute 
    {
        public HtmlKindAttribute() : base("kind", "Kind", null, false, false) 
        {
        }

        public HtmlKindAttribute(string value) : base("kind", "Kind", value, false, false) 
        {
        }
    }
}
