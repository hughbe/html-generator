namespace HtmlGenerator
{
    public class HtmlLoopAttribute : HtmlAttribute 
    {
        public HtmlLoopAttribute() : base("loop", "Loop", null, false, false) 
        {
        }

        public HtmlLoopAttribute(string value) : base("loop", "Loop", value, false, false) 
        {
        }
    }
}
