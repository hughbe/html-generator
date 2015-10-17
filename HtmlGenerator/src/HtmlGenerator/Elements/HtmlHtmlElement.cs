namespace HtmlGenerator
{
    public class HtmlHtmlElement : HtmlElement 
    {
        internal HtmlHtmlElement() : base("html", false) 
        {    
        }

		public HtmlHtmlElement WithXmlsAttribute(string value) => (HtmlHtmlElement)WithAttribute(Attribute.Xmls(value));
    }
}
