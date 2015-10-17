namespace HtmlGenerator
{
    public class HtmlTextAreaElement : HtmlElement 
    {
        internal HtmlTextAreaElement() : base("textarea", false) 
        {    
        }

		public HtmlTextAreaElement WithAutoComplete(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.AutoComplete(value));

		public HtmlTextAreaElement WithAutoFocus() => (HtmlTextAreaElement)WithAttribute(Attribute.AutoFocus);

		public HtmlTextAreaElement WithCols(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Cols(value));

		public HtmlTextAreaElement WithDisabled() => (HtmlTextAreaElement)WithAttribute(Attribute.Disabled);

		public HtmlTextAreaElement WithForm(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Form(value));

		public HtmlTextAreaElement WithMaxLength(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.MaxLength(value));

		public HtmlTextAreaElement WithMinLength(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.MinLength(value));

		public HtmlTextAreaElement WithName(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Name(value));

		public HtmlTextAreaElement WithPlaceholder(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Placeholder(value));

		public HtmlTextAreaElement WithReadonly() => (HtmlTextAreaElement)WithAttribute(Attribute.Readonly);

		public HtmlTextAreaElement WithRequired() => (HtmlTextAreaElement)WithAttribute(Attribute.Required);

		public HtmlTextAreaElement WithRows(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Rows(value));

		public HtmlTextAreaElement WithSelectionDirection(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.SelectionDirection(value));

		public HtmlTextAreaElement WithWrap(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Wrap(value));

		public HtmlTextAreaElement WithAccessKey(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTextAreaElement WithClass(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Class(value));

		public HtmlTextAreaElement WithContentEditable(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTextAreaElement WithContextMenu(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTextAreaElement WithDir(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Dir(value));

		public HtmlTextAreaElement WithHidden(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTextAreaElement WithId(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Id(value));

		public HtmlTextAreaElement WithLang(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Lang(value));

		public HtmlTextAreaElement WithSpellCheck(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTextAreaElement WithStyle(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Style(value));

		public HtmlTextAreaElement WithTabIndex(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.TabIndex(value));
    }
}
