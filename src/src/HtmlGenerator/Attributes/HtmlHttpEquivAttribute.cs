namespace HtmlGenerator
{
    public class HtmlHttpEquivAttribute : HtmlAttribute 
    {
        public HtmlHttpEquivAttribute() : base("http-equiv", "HttpEquiv", null, false, false) 
        {
        }

        public HtmlHttpEquivAttribute(string value) : base("http-equiv", "HttpEquiv", value, false, false) 
        {
        }
    }
}
