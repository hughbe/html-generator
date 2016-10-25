namespace HtmlGenerator.Elements
{
    public class HtmlTextAreaElement : HtmlElement
    {
        public HtmlTextAreaElement() : base("textarea") { }

        public HtmlTextAreaElement WithAutoComplete(string value) => this.WithAttribute(Attribute.AutoComplete(value));

        public HtmlTextAreaElement WithAutoFocus() => this.WithAttribute(Attribute.AutoFocus);

        public HtmlTextAreaElement WithCols(string value) => this.WithAttribute(Attribute.Cols(value));

        public HtmlTextAreaElement WithDisabled() => this.WithAttribute(Attribute.Disabled);

        public HtmlTextAreaElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));

        public HtmlTextAreaElement WithMaxLength(string value) => this.WithAttribute(Attribute.MaxLength(value));

        public HtmlTextAreaElement WithMinLength(string value) => this.WithAttribute(Attribute.MinLength(value));

        public HtmlTextAreaElement WithName(string value) => this.WithAttribute(Attribute.Name(value));

        public HtmlTextAreaElement WithPlaceholder(string value) => this.WithAttribute(Attribute.Placeholder(value));

        public HtmlTextAreaElement WithReadonly() => this.WithAttribute(Attribute.Readonly);

        public HtmlTextAreaElement WithRequired() => this.WithAttribute(Attribute.Required);

        public HtmlTextAreaElement WithRows(string value) => this.WithAttribute(Attribute.Rows(value));

        public HtmlTextAreaElement WithSelectionDirection(string value) => this.WithAttribute(Attribute.SelectionDirection(value));

        public HtmlTextAreaElement WithWrap(string value) => this.WithAttribute(Attribute.Wrap(value));
    }
}
