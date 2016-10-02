using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlInputElement : HtmlElement
    {
        public HtmlInputElement() : base("input", true) 
        {    
        }

        public new HtmlInputElement WithElement(HtmlElement element) => (HtmlInputElement)base.WithElement(element);
        public new HtmlInputElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlInputElement)base.WithElements(elements);

        public new HtmlInputElement WithInnerText(string innerText) => (HtmlInputElement)base.WithInnerText(innerText);

        public new HtmlInputElement WithAttribute(HtmlAttribute attribute) => (HtmlInputElement)base.WithAttribute(attribute);
        public new HtmlInputElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlInputElement)base.WithAttributes(attributes);

		public HtmlInputElement WithAccept(string value) => WithAttribute(Attribute.Accept(value));

		public HtmlInputElement WithAutoComplete(string value) => WithAttribute(Attribute.AutoComplete(value));

		public HtmlInputElement WithAutoFocus() => WithAttribute(Attribute.AutoFocus);

		public HtmlInputElement WithAutoSave(string value) => WithAttribute(Attribute.AutoSave(value));

		public HtmlInputElement WithChecked() => WithAttribute(Attribute.Checked);

		public HtmlInputElement WithDisabled() => WithAttribute(Attribute.Disabled);

		public HtmlInputElement WithForm(string value) => WithAttribute(Attribute.Form(value));

		public HtmlInputElement WithFormAction(string value) => WithAttribute(Attribute.FormAction(value));

		public HtmlInputElement WithFormEncType(string value) => WithAttribute(Attribute.FormEncType(value));

		public HtmlInputElement WithFormMethod(string value) => WithAttribute(Attribute.FormMethod(value));

		public HtmlInputElement WithFormNoValidate() => WithAttribute(Attribute.FormNoValidate);

		public HtmlInputElement WithFormTarget(string value) => WithAttribute(Attribute.FormTarget(value));

		public HtmlInputElement WithHeight(string value) => WithAttribute(Attribute.Height(value));

		public HtmlInputElement WithInputMode(string value) => WithAttribute(Attribute.InputMode(value));

		public HtmlInputElement WithList(string value) => WithAttribute(Attribute.List(value));

		public HtmlInputElement WithMax(string value) => WithAttribute(Attribute.Max(value));

		public HtmlInputElement WithMaxLength(string value) => WithAttribute(Attribute.MaxLength(value));

		public HtmlInputElement WithMin(string value) => WithAttribute(Attribute.Min(value));

		public HtmlInputElement WithMinLength(string value) => WithAttribute(Attribute.MinLength(value));

		public HtmlInputElement WithMultiple() => WithAttribute(Attribute.Multiple);

		public HtmlInputElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlInputElement WithPattern(string value) => WithAttribute(Attribute.Pattern(value));

		public HtmlInputElement WithPlaceholder(string value) => WithAttribute(Attribute.Placeholder(value));

		public HtmlInputElement WithReadonly() => WithAttribute(Attribute.Readonly);

		public HtmlInputElement WithRequired() => WithAttribute(Attribute.Required);

		public HtmlInputElement WithSelectionDirection(string value) => WithAttribute(Attribute.SelectionDirection(value));

		public HtmlInputElement WithSize(string value) => WithAttribute(Attribute.Size(value));

		public HtmlInputElement WithSrc(string value) => WithAttribute(Attribute.Src(value));

		public HtmlInputElement WithStep(string value) => WithAttribute(Attribute.Step(value));

		public HtmlInputElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlInputElement WithValue(string value) => WithAttribute(Attribute.Value(value));

		public HtmlInputElement WithWidth(string value) => WithAttribute(Attribute.Width(value));

		public HtmlInputElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlInputElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlInputElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlInputElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlInputElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlInputElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlInputElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlInputElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlInputElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlInputElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlInputElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
