namespace HtmlGenerator
{
    public class HtmlRefreshAttribute : HtmlAttribute 
    {
        public HtmlRefreshAttribute() : base("refresh", "Refresh", null, false, false) 
        {
        }

        public HtmlRefreshAttribute(string value) : base("refresh", "Refresh", value, false, false) 
        {
        }
    }
}
