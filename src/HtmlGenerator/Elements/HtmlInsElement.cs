namespace HtmlGenerator
{
    public class HtmlInsElement : HtmlElement
    {
        public HtmlInsElement() : base("ins", false) 
        {    
        }

		public HtmlInsElement WithCite(string value) => this.WithAttribute(Attribute.Cite(value));

		public HtmlInsElement WithDateTime(string value) => this.WithAttribute(Attribute.DateTime(value));
    }
}
