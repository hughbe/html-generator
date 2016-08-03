namespace HtmlGenerator
{
    public class HtmlIconAttribute : HtmlAttribute 
    {
        public HtmlIconAttribute() : base("icon", "Icon", null, false, false) 
        {
        }

        public HtmlIconAttribute(string value) : base("icon", "Icon", value, false, false) 
        {
        }
    }
}
