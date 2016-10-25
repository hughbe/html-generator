namespace HtmlGenerator.Elements
{
    public class HtmlObjectElement : HtmlElement
    {
        public HtmlObjectElement() : base("object") { }

        public HtmlObjectElement WithData(string value) => this.WithAttribute(Attribute.Data(value));

        public HtmlObjectElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));

        public HtmlObjectElement WithHeight(string value) => this.WithAttribute(Attribute.Height(value));

        public HtmlObjectElement WithName(string value) => this.WithAttribute(Attribute.Name(value));

        public HtmlObjectElement WithType(string value) => this.WithAttribute(Attribute.Type(value));

        public HtmlObjectElement WithTypeMustMatch() => this.WithAttribute(Attribute.TypeMustMatch);

        public HtmlObjectElement WithUseMap(string value) => this.WithAttribute(Attribute.UseMap(value));

        public HtmlObjectElement WithWidth(string value) => this.WithAttribute(Attribute.Width(value));
    }
}
