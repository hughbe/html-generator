namespace HtmlGenerator
{
    public class HtmlProgressElement : HtmlElement
    {
        public HtmlProgressElement() : base("progress", false) 
        {    
        }

		public HtmlProgressElement WithMax(string value) => this.WithAttribute(Attribute.Max(value));

		public HtmlProgressElement WithValue(string value) => this.WithAttribute(Attribute.Value(value));
    }
}
