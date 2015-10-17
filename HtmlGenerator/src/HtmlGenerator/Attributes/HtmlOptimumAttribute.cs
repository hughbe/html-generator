namespace HtmlGenerator
{
    public class HtmlOptimumAttribute : HtmlAttribute 
    {
        internal HtmlOptimumAttribute() : base("optimum", "Optimum", null, false) 
        {
        }

        internal HtmlOptimumAttribute(string value) : base("optimum", "Optimum", value, false) 
        {
        }
    }
}
