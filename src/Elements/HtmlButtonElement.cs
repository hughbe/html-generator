namespace HtmlGenerator.Elements
{
    public class HtmlButtonElement : HtmlElement
    {
        public HtmlButtonElement() : base("button") { }

        public HtmlButtonElement WithAutoFocus() => this.WithAttribute(Attribute.AutoFocus);

        public HtmlButtonElement WithDisabled() => this.WithAttribute(Attribute.Disabled);

        public HtmlButtonElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));

        public HtmlButtonElement WithFormAction(string value) => this.WithAttribute(Attribute.FormAction(value));

        public HtmlButtonElement WithFormEncType(string value) => this.WithAttribute(Attribute.FormEncType(value));

        public HtmlButtonElement WithFormMethod(string value) => this.WithAttribute(Attribute.FormMethod(value));

        public HtmlButtonElement WithFormNoValidate() => this.WithAttribute(Attribute.FormNoValidate);

        public HtmlButtonElement WithFormTarget(string value) => this.WithAttribute(Attribute.FormTarget(value));

        public HtmlButtonElement WithName(string value) => this.WithAttribute(Attribute.Name(value));

        public HtmlButtonElement WithType(string value) => this.WithAttribute(Attribute.Type(value));

        public HtmlButtonElement WithValue(string value) => this.WithAttribute(Attribute.Value(value));
    }
}
