namespace HtmlGenerator
{
    public class HtmlRefreshAttribute : HtmlAttribute 
    {
        internal HtmlRefreshAttribute() : base("refresh", "Refresh", null, false) 
        {
        }

        internal HtmlRefreshAttribute(string value) : base("refresh", "Refresh", value, false) 
        {
        }
    }
}
