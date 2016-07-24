namespace HtmlGenerator
{
    public class HtmlTypeAttribute : HtmlAttribute 
    {
        public HtmlTypeAttribute() : base("type", "Type", null, false, false) 
        {
        }

        public HtmlTypeAttribute(string value) : base("type", "Type", value, false, false) 
        {
        }
    }
}
