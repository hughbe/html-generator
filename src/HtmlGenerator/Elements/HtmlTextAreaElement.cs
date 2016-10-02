using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlTextAreaElement : HtmlElement
    {
        public HtmlTextAreaElement() : base("textarea", false) 
        {    
        }

        public new HtmlTextAreaElement WithElement(HtmlElement element) => (HtmlTextAreaElement)base.WithElement(element);
        public new HtmlTextAreaElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlTextAreaElement)base.WithElements(elements);

        public new HtmlTextAreaElement WithInnerText(string innerText) => (HtmlTextAreaElement)base.WithInnerText(innerText);

        public new HtmlTextAreaElement WithAttribute(HtmlAttribute attribute) => (HtmlTextAreaElement)base.WithAttribute(attribute);
        public new HtmlTextAreaElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlTextAreaElement)base.WithAttributes(attributes);

		public HtmlTextAreaElement WithAutoComplete(string value) => WithAttribute(Attribute.AutoComplete(value));

		public HtmlTextAreaElement WithAutoFocus() => WithAttribute(Attribute.AutoFocus);

		public HtmlTextAreaElement WithCols(string value) => WithAttribute(Attribute.Cols(value));

		public HtmlTextAreaElement WithDisabled() => WithAttribute(Attribute.Disabled);

		public HtmlTextAreaElement WithForm(string value) => WithAttribute(Attribute.Form(value));

		public HtmlTextAreaElement WithMaxLength(string value) => WithAttribute(Attribute.MaxLength(value));

		public HtmlTextAreaElement WithMinLength(string value) => WithAttribute(Attribute.MinLength(value));

		public HtmlTextAreaElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlTextAreaElement WithPlaceholder(string value) => WithAttribute(Attribute.Placeholder(value));

		public HtmlTextAreaElement WithReadonly() => WithAttribute(Attribute.Readonly);

		public HtmlTextAreaElement WithRequired() => WithAttribute(Attribute.Required);

		public HtmlTextAreaElement WithRows(string value) => WithAttribute(Attribute.Rows(value));

		public HtmlTextAreaElement WithSelectionDirection(string value) => WithAttribute(Attribute.SelectionDirection(value));

		public HtmlTextAreaElement WithWrap(string value) => WithAttribute(Attribute.Wrap(value));

		public HtmlTextAreaElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlTextAreaElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlTextAreaElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlTextAreaElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlTextAreaElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlTextAreaElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlTextAreaElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlTextAreaElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlTextAreaElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlTextAreaElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlTextAreaElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
