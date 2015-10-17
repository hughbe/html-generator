namespace HtmlGenerator
{
    public class HtmlHeightAttribute : HtmlAttribute 
    {
        internal HtmlHeightAttribute() : base("height", "Height", null, false, false) 
        {
        }

        internal HtmlHeightAttribute(string value) : base("height", "Height", value, false, false) 
        {
        }
    }
}
