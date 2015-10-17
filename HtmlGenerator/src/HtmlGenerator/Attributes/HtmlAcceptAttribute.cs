namespace HtmlGenerator
{
    public class HtmlAcceptAttribute : HtmlAttribute 
    {
        internal HtmlAcceptAttribute() : base("accept", "Accept", null, false, false) 
        {
        }

        internal HtmlAcceptAttribute(string value) : base("accept", "Accept", value, false, false) 
        {
        }
    }
}
