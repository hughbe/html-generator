namespace HtmlGenerator.Elements
{
    public class HtmlLabelElement : HtmlElement
    {
        public HtmlLabelElement() : base("label") { }

        public HtmlLabelElement WithFor(string value) => this.WithAttribute(Attribute.For(value));

        public HtmlLabelElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));
    }
}
