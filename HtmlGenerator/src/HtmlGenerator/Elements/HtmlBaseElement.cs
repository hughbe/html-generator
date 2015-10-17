namespace HtmlGenerator
{
    public class HtmlBaseElement : HtmlElement 
    {
        internal HtmlBaseElement() : base("base", true) 
        {    
        }

		public HtmlBaseElement WithHrefAttribute(string value) => (HtmlBaseElement)WithAttribute(Attribute.Href(value));

		public HtmlBaseElement WithTargetAttribute(string value) => (HtmlBaseElement)WithAttribute(Attribute.Target(value));
    }
}
