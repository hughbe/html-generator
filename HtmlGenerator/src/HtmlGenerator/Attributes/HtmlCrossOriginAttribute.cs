namespace HtmlGenerator
{
    public class HtmlCrossOriginAttribute : HtmlAttribute 
    {
        internal HtmlCrossOriginAttribute() : base("crossorigin", "CrossOrigin", null, false) 
        {
        }

        internal HtmlCrossOriginAttribute(string value) : base("crossorigin", "CrossOrigin", value, false) 
        {
        }
    }
}
