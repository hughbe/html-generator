namespace HtmlGenerator
{
    public class HtmlMenuElement : HtmlElement 
    {
        internal HtmlMenuElement() : base("menu", false) 
        {    
        }

		public HtmlMenuElement WithLabelAttribute(string value) => (HtmlMenuElement)WithAttribute(Attribute.Label(value));

		public HtmlMenuElement WithTypeAttribute(string value) => (HtmlMenuElement)WithAttribute(Attribute.Type(value));
    }
}
