namespace HtmlGenerator
{
    public class HtmlBaseElement : HtmlElement
    {
        public HtmlBaseElement() : base("base", true) 
        {    
        }

		public HtmlBaseElement WithHref(string value) => this.WithAttribute(Attribute.Href(value));

		public HtmlBaseElement WithTarget(string value) => this.WithAttribute(Attribute.Target(value));
    }
}
