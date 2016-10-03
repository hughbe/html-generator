namespace HtmlGenerator
{
    public class HtmlLabelElement : HtmlElement
    {
        public HtmlLabelElement() : base("label", false) 
        {    
        }

		public HtmlLabelElement WithFor(string value) => this.WithAttribute(Attribute.For(value));

		public HtmlLabelElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));
    }
}
