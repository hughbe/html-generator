namespace HtmlGenerator
{
    public class HtmlIdAttribute : HtmlAttribute 
    {
        internal HtmlIdAttribute() : base("id", "Id", null, false, true) 
        {
        }

        internal HtmlIdAttribute(string value) : base("id", "Id", value, false, true) 
        {
        }
    }
}
