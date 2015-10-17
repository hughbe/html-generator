namespace HtmlGenerator
{
    public class HtmlIdAttribute : HtmlAttribute 
    {
        internal HtmlIdAttribute() : base("id", "Id", null, false) 
        {
        }

        internal HtmlIdAttribute(string value) : base("id", "Id", value, false) 
        {
        }
    }
}
