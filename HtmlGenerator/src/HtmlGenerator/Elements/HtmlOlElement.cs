namespace HtmlGenerator
{
    public class HtmlOlElement : HtmlElement 
    {
        internal HtmlOlElement() : base("ol", false) 
        {    
        }

		public HtmlOlElement WithReversedAttribute(string value) => (HtmlOlElement)WithAttribute(Attribute.Reversed(value));

		public HtmlOlElement WithStartAttribute(string value) => (HtmlOlElement)WithAttribute(Attribute.Start(value));

		public HtmlOlElement WithTypeAttribute(string value) => (HtmlOlElement)WithAttribute(Attribute.Type(value));
    }
}
