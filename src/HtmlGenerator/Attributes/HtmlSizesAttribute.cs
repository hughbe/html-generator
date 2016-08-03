namespace HtmlGenerator
{
    public class HtmlSizesAttribute : HtmlAttribute 
    {
        public HtmlSizesAttribute() : base("sizes", "Sizes", null, false, false) 
        {
        }

        public HtmlSizesAttribute(string value) : base("sizes", "Sizes", value, false, false) 
        {
        }
    }
}
