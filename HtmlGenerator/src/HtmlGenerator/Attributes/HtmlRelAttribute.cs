namespace HtmlGenerator
{
    public class HtmlRelAttribute : HtmlAttribute 
    {
        public HtmlRelAttribute() : base("rel", "Rel", null, false, false) 
        {
        }

        public HtmlRelAttribute(string value) : base("rel", "Rel", value, false, false) 
        {
        }
    }
}
