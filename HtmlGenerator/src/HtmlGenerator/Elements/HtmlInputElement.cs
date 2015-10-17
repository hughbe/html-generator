namespace HtmlGenerator
{
    public class HtmlInputElement : HtmlElement 
    {
        internal HtmlInputElement() : base("input", true) 
        {    
        }

		public HtmlInputElement WithAcceptAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Accept(value));

		public HtmlInputElement WithAutoCompleteAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.AutoComplete(value));

		public HtmlInputElement WithAutoFocusAttribute() => (HtmlInputElement)WithAttribute(Attribute.AutoFocus);

		public HtmlInputElement WithAutoSaveAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.AutoSave(value));

		public HtmlInputElement WithCheckedAttribute() => (HtmlInputElement)WithAttribute(Attribute.Checked);

		public HtmlInputElement WithDisabledAttribute() => (HtmlInputElement)WithAttribute(Attribute.Disabled);

		public HtmlInputElement WithFormAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Form(value));

		public HtmlInputElement WithFormActionAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.FormAction(value));

		public HtmlInputElement WithFormEncTypeAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.FormEncType(value));

		public HtmlInputElement WithFormMethodAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.FormMethod(value));

		public HtmlInputElement WithFormNoValidateAttribute() => (HtmlInputElement)WithAttribute(Attribute.FormNoValidate);

		public HtmlInputElement WithFormTargetAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.FormTarget(value));

		public HtmlInputElement WithHeightAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Height(value));

		public HtmlInputElement WithInputModeAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.InputMode(value));

		public HtmlInputElement WithListAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.List(value));

		public HtmlInputElement WithMaxAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Max(value));

		public HtmlInputElement WithMaxLengthAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.MaxLength(value));

		public HtmlInputElement WithMinAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Min(value));

		public HtmlInputElement WithMinLengthAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.MinLength(value));

		public HtmlInputElement WithMultipleAttribute() => (HtmlInputElement)WithAttribute(Attribute.Multiple);

		public HtmlInputElement WithNameAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Name(value));

		public HtmlInputElement WithPatternAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Pattern(value));

		public HtmlInputElement WithPlaceholderAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Placeholder(value));

		public HtmlInputElement WithReadonlyAttribute() => (HtmlInputElement)WithAttribute(Attribute.Readonly);

		public HtmlInputElement WithRequiredAttribute() => (HtmlInputElement)WithAttribute(Attribute.Required);

		public HtmlInputElement WithSelectionDirectionAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.SelectionDirection(value));

		public HtmlInputElement WithSizeAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Size(value));

		public HtmlInputElement WithSrcAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Src(value));

		public HtmlInputElement WithStepAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Step(value));

		public HtmlInputElement WithTabIndexAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.TabIndex(value));

		public HtmlInputElement WithTypeAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Type(value));

		public HtmlInputElement WithValueAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Value(value));

		public HtmlInputElement WithWidthAttribute(string value) => (HtmlInputElement)WithAttribute(Attribute.Width(value));
    }
}
