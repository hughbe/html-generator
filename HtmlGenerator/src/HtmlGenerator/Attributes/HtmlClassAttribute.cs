namespace HtmlGenerator
{
    public class HtmlClassAttribute : HtmlAttribute 
    {
        public HtmlClassAttribute() : base("class", "Class", null, false, true) 
        {
        }

        public HtmlClassAttribute(string value) : base("class", "Class", value, false, true) 
        {
        }
    }
}
