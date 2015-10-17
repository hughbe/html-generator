namespace HtmlGenerator
{
    public class HtmlInputElement : HtmlElement 
    {
        internal HtmlInputElement() : base("input", true) 
        {    
        }

		public HtmlInputElement WithAccept(string value) => (HtmlInputElement)WithAttribute(Attribute.Accept(value));

		public HtmlInputElement WithAutoComplete(string value) => (HtmlInputElement)WithAttribute(Attribute.AutoComplete(value));

		public HtmlInputElement WithAutoFocus() => (HtmlInputElement)WithAttribute(Attribute.AutoFocus);

		public HtmlInputElement WithAutoSave(string value) => (HtmlInputElement)WithAttribute(Attribute.AutoSave(value));

		public HtmlInputElement WithChecked() => (HtmlInputElement)WithAttribute(Attribute.Checked);

		public HtmlInputElement WithDisabled() => (HtmlInputElement)WithAttribute(Attribute.Disabled);

		public HtmlInputElement WithForm(string value) => (HtmlInputElement)WithAttribute(Attribute.Form(value));

		public HtmlInputElement WithFormAction(string value) => (HtmlInputElement)WithAttribute(Attribute.FormAction(value));

		public HtmlInputElement WithFormEncType(string value) => (HtmlInputElement)WithAttribute(Attribute.FormEncType(value));

		public HtmlInputElement WithFormMethod(string value) => (HtmlInputElement)WithAttribute(Attribute.FormMethod(value));

		public HtmlInputElement WithFormNoValidate() => (HtmlInputElement)WithAttribute(Attribute.FormNoValidate);

		public HtmlInputElement WithFormTarget(string value) => (HtmlInputElement)WithAttribute(Attribute.FormTarget(value));

		public HtmlInputElement WithHeight(string value) => (HtmlInputElement)WithAttribute(Attribute.Height(value));

		public HtmlInputElement WithInputMode(string value) => (HtmlInputElement)WithAttribute(Attribute.InputMode(value));

		public HtmlInputElement WithList(string value) => (HtmlInputElement)WithAttribute(Attribute.List(value));

		public HtmlInputElement WithMax(string value) => (HtmlInputElement)WithAttribute(Attribute.Max(value));

		public HtmlInputElement WithMaxLength(string value) => (HtmlInputElement)WithAttribute(Attribute.MaxLength(value));

		public HtmlInputElement WithMin(string value) => (HtmlInputElement)WithAttribute(Attribute.Min(value));

		public HtmlInputElement WithMinLength(string value) => (HtmlInputElement)WithAttribute(Attribute.MinLength(value));

		public HtmlInputElement WithMultiple() => (HtmlInputElement)WithAttribute(Attribute.Multiple);

		public HtmlInputElement WithName(string value) => (HtmlInputElement)WithAttribute(Attribute.Name(value));

		public HtmlInputElement WithPattern(string value) => (HtmlInputElement)WithAttribute(Attribute.Pattern(value));

		public HtmlInputElement WithPlaceholder(string value) => (HtmlInputElement)WithAttribute(Attribute.Placeholder(value));

		public HtmlInputElement WithReadonly() => (HtmlInputElement)WithAttribute(Attribute.Readonly);

		public HtmlInputElement WithRequired() => (HtmlInputElement)WithAttribute(Attribute.Required);

		public HtmlInputElement WithSelectionDirection(string value) => (HtmlInputElement)WithAttribute(Attribute.SelectionDirection(value));

		public HtmlInputElement WithSize(string value) => (HtmlInputElement)WithAttribute(Attribute.Size(value));

		public HtmlInputElement WithSrc(string value) => (HtmlInputElement)WithAttribute(Attribute.Src(value));

		public HtmlInputElement WithStep(string value) => (HtmlInputElement)WithAttribute(Attribute.Step(value));

		public HtmlInputElement WithType(string value) => (HtmlInputElement)WithAttribute(Attribute.Type(value));

		public HtmlInputElement WithValue(string value) => (HtmlInputElement)WithAttribute(Attribute.Value(value));

		public HtmlInputElement WithWidth(string value) => (HtmlInputElement)WithAttribute(Attribute.Width(value));

		public HtmlInputElement WithAccessKey(string value) => (HtmlInputElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlInputElement WithClass(string value) => (HtmlInputElement)WithAttribute(Attribute.Class(value));

		public HtmlInputElement WithContentEditable(string value) => (HtmlInputElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlInputElement WithContextMenu(string value) => (HtmlInputElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlInputElement WithDir(string value) => (HtmlInputElement)WithAttribute(Attribute.Dir(value));

		public HtmlInputElement WithHidden(string value) => (HtmlInputElement)WithAttribute(Attribute.Hidden(value));

		public HtmlInputElement WithId(string value) => (HtmlInputElement)WithAttribute(Attribute.Id(value));

		public HtmlInputElement WithLang(string value) => (HtmlInputElement)WithAttribute(Attribute.Lang(value));

		public HtmlInputElement WithSpellCheck(string value) => (HtmlInputElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlInputElement WithStyle(string value) => (HtmlInputElement)WithAttribute(Attribute.Style(value));

		public HtmlInputElement WithTabIndex(string value) => (HtmlInputElement)WithAttribute(Attribute.TabIndex(value));
    }
}
