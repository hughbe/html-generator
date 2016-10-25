namespace HtmlGenerator.Elements
{
    public class HtmlInputElement : HtmlElement
    {
        public HtmlInputElement() : base("input", isVoid: true) { }

        public HtmlInputElement WithAccept(string value) => this.WithAttribute(Attribute.Accept(value));

        public HtmlInputElement WithAutoComplete(string value) => this.WithAttribute(Attribute.AutoComplete(value));

        public HtmlInputElement WithAutoFocus() => this.WithAttribute(Attribute.AutoFocus);

        public HtmlInputElement WithAutoSave(string value) => this.WithAttribute(Attribute.AutoSave(value));

        public HtmlInputElement WithChecked() => this.WithAttribute(Attribute.Checked);

        public HtmlInputElement WithDisabled() => this.WithAttribute(Attribute.Disabled);

        public HtmlInputElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));

        public HtmlInputElement WithFormAction(string value) => this.WithAttribute(Attribute.FormAction(value));

        public HtmlInputElement WithFormEncType(string value) => this.WithAttribute(Attribute.FormEncType(value));

        public HtmlInputElement WithFormMethod(string value) => this.WithAttribute(Attribute.FormMethod(value));

        public HtmlInputElement WithFormNoValidate() => this.WithAttribute(Attribute.FormNoValidate);

        public HtmlInputElement WithFormTarget(string value) => this.WithAttribute(Attribute.FormTarget(value));

        public HtmlInputElement WithHeight(string value) => this.WithAttribute(Attribute.Height(value));

        public HtmlInputElement WithInputMode(string value) => this.WithAttribute(Attribute.InputMode(value));

        public HtmlInputElement WithList(string value) => this.WithAttribute(Attribute.List(value));

        public HtmlInputElement WithMax(string value) => this.WithAttribute(Attribute.Max(value));

        public HtmlInputElement WithMaxLength(string value) => this.WithAttribute(Attribute.MaxLength(value));

        public HtmlInputElement WithMin(string value) => this.WithAttribute(Attribute.Min(value));

        public HtmlInputElement WithMinLength(string value) => this.WithAttribute(Attribute.MinLength(value));

        public HtmlInputElement WithMultiple() => this.WithAttribute(Attribute.Multiple);

        public HtmlInputElement WithName(string value) => this.WithAttribute(Attribute.Name(value));

        public HtmlInputElement WithPattern(string value) => this.WithAttribute(Attribute.Pattern(value));

        public HtmlInputElement WithPlaceholder(string value) => this.WithAttribute(Attribute.Placeholder(value));

        public HtmlInputElement WithReadonly() => this.WithAttribute(Attribute.Readonly);

        public HtmlInputElement WithRequired() => this.WithAttribute(Attribute.Required);

        public HtmlInputElement WithSelectionDirection(string value) => this.WithAttribute(Attribute.SelectionDirection(value));

        public HtmlInputElement WithSize(string value) => this.WithAttribute(Attribute.Size(value));

        public HtmlInputElement WithSrc(string value) => this.WithAttribute(Attribute.Src(value));

        public HtmlInputElement WithStep(string value) => this.WithAttribute(Attribute.Step(value));

        public HtmlInputElement WithType(string value) => this.WithAttribute(Attribute.Type(value));

        public HtmlInputElement WithValue(string value) => this.WithAttribute(Attribute.Value(value));

        public HtmlInputElement WithWidth(string value) => this.WithAttribute(Attribute.Width(value));
    }
}
