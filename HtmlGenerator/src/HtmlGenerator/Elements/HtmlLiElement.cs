namespace HtmlGenerator
{
    public class HtmlLiElement : HtmlElement 
    {
        internal HtmlLiElement() : base("li", false) 
        {    
        }

		public HtmlLiElement WithValueAttribute(string value) => (HtmlLiElement)WithAttribute(Attribute.Value(value));
    }
}
