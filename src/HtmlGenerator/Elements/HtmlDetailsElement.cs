namespace HtmlGenerator
{
    public class HtmlDetailsElement : HtmlElement
    {
        public HtmlDetailsElement() : base("details", false) 
        {    
        }

		public HtmlDetailsElement WithOpen(string value) => this.WithAttribute(Attribute.Open(value));
    }
}
