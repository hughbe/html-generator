namespace HtmlGenerator.Elements
{
    public class HtmlOutputElement : HtmlElement
    {
        public HtmlOutputElement() : base("output") { }

        public HtmlOutputElement WithFor(string value) => this.WithAttribute(Attribute.For(value));

        public HtmlOutputElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));

        public HtmlOutputElement WithName(string value) => this.WithAttribute(Attribute.Name(value));
    }
}
