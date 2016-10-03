namespace HtmlGenerator
{
    public class HtmlDdElement : HtmlElement
    {
        public HtmlDdElement() : base("dd", false) 
        {    
        }

		public HtmlDdElement WithNoWrap(string value) => this.WithAttribute(Attribute.NoWrap(value));
    }
}
