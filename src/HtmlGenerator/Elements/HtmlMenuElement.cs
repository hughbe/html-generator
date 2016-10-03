namespace HtmlGenerator
{
    public class HtmlMenuElement : HtmlElement
    {
        public HtmlMenuElement() : base("menu", false) 
        {    
        }

		public HtmlMenuElement WithLabel(string value) => this.WithAttribute(Attribute.Label(value));

		public HtmlMenuElement WithType(string value) => this.WithAttribute(Attribute.Type(value));
    }
}
