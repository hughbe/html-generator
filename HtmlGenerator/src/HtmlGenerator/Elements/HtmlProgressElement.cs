namespace HtmlGenerator
{
    public class HtmlProgressElement : HtmlElement 
    {
        internal HtmlProgressElement() : base("progress", false) 
        {    
        }

		public HtmlProgressElement WithMaxAttribute(string value) => (HtmlProgressElement)WithAttribute(Attribute.Max(value));

		public HtmlProgressElement WithValueAttribute(string value) => (HtmlProgressElement)WithAttribute(Attribute.Value(value));
    }
}
