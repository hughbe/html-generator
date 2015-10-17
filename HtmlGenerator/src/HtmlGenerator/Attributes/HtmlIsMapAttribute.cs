namespace HtmlGenerator
{
    public class HtmlIsMapAttribute : HtmlAttribute 
    {
        public HtmlIsMapAttribute() : base("ismap", "IsMap", null, false, false) 
        {
        }

        public HtmlIsMapAttribute(string value) : base("ismap", "IsMap", value, false, false) 
        {
        }
    }
}
