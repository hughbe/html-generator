namespace HtmlGenerator
{
    public class HtmlDataAttribute : HtmlAttribute 
    {
        public HtmlDataAttribute() : base("data", "Data", null, false, false) 
        {
        }

        public HtmlDataAttribute(string value) : base("data", "Data", value, false, false) 
        {
        }
    }
}
