namespace HtmlGenerator
{
    public class HtmlHtmlElement : HtmlElement
    {
        public HtmlHtmlElement() : base("html", false) 
        {    
        }

		public HtmlHtmlElement WithXmls(string value) => this.WithAttribute(Attribute.Xmls(value));
    }
}
