namespace HtmlGenerator
{
    public class HtmlTypeAttribute : HtmlAttribute 
    {
        internal HtmlTypeAttribute() : base("type", "Type", null, false, false) 
        {
        }

        internal HtmlTypeAttribute(string value) : base("type", "Type", value, false, false) 
        {
        }
    }
}
