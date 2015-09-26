namespace HtmlGenerator
{
    public class HtmlAcceptAttribute : HtmlAttribute 
    {
        public HtmlAcceptAttribute() : base("accept", "Accept", null, false, false) 
        {
        }

        public HtmlAcceptAttribute(string value) : base("accept", "Accept", value, false, false) 
        {
        }
    }
}
