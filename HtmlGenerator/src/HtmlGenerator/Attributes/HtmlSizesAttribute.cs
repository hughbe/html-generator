namespace HtmlGenerator
{
    public class HtmlSizesAttribute : HtmlAttribute 
    {
        internal HtmlSizesAttribute() : base("sizes", "Sizes", null, false) 
        {
        }

        internal HtmlSizesAttribute(string value) : base("sizes", "Sizes", value, false) 
        {
        }
    }
}
