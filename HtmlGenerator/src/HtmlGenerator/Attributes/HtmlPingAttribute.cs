namespace HtmlGenerator
{
    public class HtmlPingAttribute : HtmlAttribute 
    {
        internal HtmlPingAttribute() : base("ping", "Ping", null, false) 
        {
        }

        internal HtmlPingAttribute(string value) : base("ping", "Ping", value, false) 
        {
        }
    }
}
