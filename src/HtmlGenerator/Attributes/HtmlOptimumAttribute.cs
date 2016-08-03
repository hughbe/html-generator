namespace HtmlGenerator
{
    public class HtmlOptimumAttribute : HtmlAttribute 
    {
        public HtmlOptimumAttribute() : base("optimum", "Optimum", null, false, false) 
        {
        }

        public HtmlOptimumAttribute(string value) : base("optimum", "Optimum", value, false, false) 
        {
        }
    }
}
