namespace HtmlGenerator.Elements
{
    public class HtmlSelectElement : HtmlElement
    {
        public HtmlSelectElement() : base("select") { }

        public HtmlSelectElement WithAutoFocus() => this.WithAttribute(Attribute.AutoFocus);

        public HtmlSelectElement WithDisabled() => this.WithAttribute(Attribute.Disabled);

        public HtmlSelectElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));

        public HtmlSelectElement WithMultiple() => this.WithAttribute(Attribute.Multiple);

        public HtmlSelectElement WithName(string value) => this.WithAttribute(Attribute.Name(value));

        public HtmlSelectElement WithRequired() => this.WithAttribute(Attribute.Required);

        public HtmlSelectElement WithSize(string value) => this.WithAttribute(Attribute.Size(value));
    }
}
