namespace HtmlGenerator
{
    public class HtmlHeightAttribute : HtmlAttribute 
    {
        public HtmlHeightAttribute() : base("height", "Height", null, false, false) 
        {
        }

        public HtmlHeightAttribute(string value) : base("height", "Height", value, false, false) 
        {
        }
    }
}
