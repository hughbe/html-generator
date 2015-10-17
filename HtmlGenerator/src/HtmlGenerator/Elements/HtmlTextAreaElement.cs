namespace HtmlGenerator
{
    public class HtmlTextAreaElement : HtmlElement 
    {
        internal HtmlTextAreaElement() : base("textarea", false) 
        {    
        }

		public HtmlTextAreaElement WithAutoCompleteAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.AutoComplete(value));

		public HtmlTextAreaElement WithAutoFocusAttribute() => (HtmlTextAreaElement)WithAttribute(Attribute.AutoFocus);

		public HtmlTextAreaElement WithColsAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Cols(value));

		public HtmlTextAreaElement WithDisabledAttribute() => (HtmlTextAreaElement)WithAttribute(Attribute.Disabled);

		public HtmlTextAreaElement WithFormAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Form(value));

		public HtmlTextAreaElement WithMaxLengthAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.MaxLength(value));

		public HtmlTextAreaElement WithMinLengthAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.MinLength(value));

		public HtmlTextAreaElement WithNameAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Name(value));

		public HtmlTextAreaElement WithPlaceholderAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Placeholder(value));

		public HtmlTextAreaElement WithReadonlyAttribute() => (HtmlTextAreaElement)WithAttribute(Attribute.Readonly);

		public HtmlTextAreaElement WithRequiredAttribute() => (HtmlTextAreaElement)WithAttribute(Attribute.Required);

		public HtmlTextAreaElement WithRowsAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Rows(value));

		public HtmlTextAreaElement WithSelectionDirectionAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.SelectionDirection(value));

		public HtmlTextAreaElement WithWrapAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Wrap(value));

		public HtmlTextAreaElement WithAccessKey(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTextAreaElement WithClass(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Class(value));

		public HtmlTextAreaElement WithContentEditable(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTextAreaElement WithContextMenuAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTextAreaElement WithDir(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Dir(value));

		public HtmlTextAreaElement WithHidden(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTextAreaElement WithId(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Id(value));

		public HtmlTextAreaElement WithLang(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Lang(value));

		public HtmlTextAreaElement WithSpellCheck(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTextAreaElement WithStyleAttribute(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.Style(value));

		public HtmlTextAreaElement WithTabIndex(string value) => (HtmlTextAreaElement)WithAttribute(Attribute.TabIndex(value));
    }
}
