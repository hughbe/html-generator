namespace HtmlGenerator
{
    public class HtmlPosterAttribute : HtmlAttribute 
    {
        public HtmlPosterAttribute() : base("poster", "Poster", null, false, false) 
        {
        }

        public HtmlPosterAttribute(string value) : base("poster", "Poster", value, false, false) 
        {
        }
    }
}
