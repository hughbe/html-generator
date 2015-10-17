namespace HtmlGenerator
{
    public class HtmlIsMapAttribute : HtmlAttribute 
    {
        internal HtmlIsMapAttribute() : base("ismap", "IsMap", null, false) 
        {
        }

        internal HtmlIsMapAttribute(string value) : base("ismap", "IsMap", value, false) 
        {
        }
    }
}
