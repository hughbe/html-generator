namespace HtmlGenerator
{
    public class HtmlLiElement : HtmlElement
    {
        public HtmlLiElement() : base("li", false) 
        {    
        }

		public HtmlLiElement WithValue(string value) => this.WithAttribute(Attribute.Value(value));
    }
}
