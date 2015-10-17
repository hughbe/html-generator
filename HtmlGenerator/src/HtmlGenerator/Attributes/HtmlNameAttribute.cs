namespace HtmlGenerator
{
    public class HtmlNameAttribute : HtmlAttribute 
    {
        internal HtmlNameAttribute() : base("name", "Name", null, false) 
        {
        }

        internal HtmlNameAttribute(string value) : base("name", "Name", value, false) 
        {
        }
    }
}
