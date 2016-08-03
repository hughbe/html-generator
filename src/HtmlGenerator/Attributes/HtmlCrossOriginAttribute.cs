namespace HtmlGenerator
{
    public class HtmlCrossOriginAttribute : HtmlAttribute 
    {
        public HtmlCrossOriginAttribute() : base("crossorigin", "CrossOrigin", null, false, false) 
        {
        }

        public HtmlCrossOriginAttribute(string value) : base("crossorigin", "CrossOrigin", value, false, false) 
        {
        }
    }
}
