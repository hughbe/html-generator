namespace HtmlGenerator
{
    public class HtmlLoopAttribute : HtmlAttribute 
    {
        internal HtmlLoopAttribute() : base("loop", "Loop", null, false, false) 
        {
        }

        internal HtmlLoopAttribute(string value) : base("loop", "Loop", value, false, false) 
        {
        }
    }
}
