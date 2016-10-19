namespace HtmlGenerator
{
    public class HtmlOutputElement : HtmlElement
    {
        public HtmlOutputElement() : base("output", false)
        {
        }

        public HtmlOutputElement WithFor(string value) => this.WithAttribute(Attribute.For(value));

        public HtmlOutputElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));

        public HtmlOutputElement WithName(string value) => this.WithAttribute(Attribute.Name(value));
    }
}
