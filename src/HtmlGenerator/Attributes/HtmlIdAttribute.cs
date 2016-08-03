namespace HtmlGenerator
{
    public class HtmlIdAttribute : HtmlAttribute 
    {
        public HtmlIdAttribute() : base("id", "Id", null, false, true) 
        {
        }

        public HtmlIdAttribute(string value) : base("id", "Id", value, false, true) 
        {
        }
    }
}
