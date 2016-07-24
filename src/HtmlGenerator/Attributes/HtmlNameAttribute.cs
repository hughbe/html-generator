namespace HtmlGenerator
{
    public class HtmlNameAttribute : HtmlAttribute 
    {
        public HtmlNameAttribute() : base("name", "Name", null, false, false) 
        {
        }

        public HtmlNameAttribute(string value) : base("name", "Name", value, false, false) 
        {
        }
    }
}
