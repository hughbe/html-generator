namespace HtmlGenerator
{
    public class HtmlHttpEquivAttribute : HtmlAttribute 
    {
        internal HtmlHttpEquivAttribute() : base("http-equiv", "HttpEquiv", null, false, false) 
        {
        }

        internal HtmlHttpEquivAttribute(string value) : base("http-equiv", "HttpEquiv", value, false, false) 
        {
        }
    }
}
