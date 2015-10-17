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
    }
}
