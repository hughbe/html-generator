namespace HtmlGenerator
{
    public class HtmlPosterAttribute : HtmlAttribute 
    {
        internal HtmlPosterAttribute() : base("poster", "Poster", null, false) 
        {
        }

        internal HtmlPosterAttribute(string value) : base("poster", "Poster", value, false) 
        {
        }
    }
}
