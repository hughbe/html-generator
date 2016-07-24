namespace HtmlGenerator
{
    public class HtmlPingAttribute : HtmlAttribute 
    {
        public HtmlPingAttribute() : base("ping", "Ping", null, false, false) 
        {
        }

        public HtmlPingAttribute(string value) : base("ping", "Ping", value, false, false) 
        {
        }
    }
}
