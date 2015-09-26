using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlButtonElement : HtmlElement 
    {
        public HtmlButtonElement() : base("button", false) 
        {    
        }

        public new HtmlButtonElement WithChild(HtmlElement child) => (HtmlButtonElement)base.WithChild(child);
        public new HtmlButtonElement WithChildren(Collection<HtmlElement> children) => (HtmlButtonElement)base.WithChildren(children);

        public new HtmlButtonElement WithInnerText(string innerText) => (HtmlButtonElement)base.WithInnerText(innerText);

        public new HtmlButtonElement WithAttribute(HtmlAttribute attribute) => (HtmlButtonElement)base.WithAttribute(attribute);
        public new HtmlButtonElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlButtonElement)base.WithAttributes(attributes);

		public HtmlButtonElement WithAutoFocus() => WithAttribute(Attribute.AutoFocus);

		public HtmlButtonElement WithDisabled() => WithAttribute(Attribute.Disabled);

		public HtmlButtonElement WithForm(string value) => WithAttribute(Attribute.Form(value));

		public HtmlButtonElement WithFormAction(string value) => WithAttribute(Attribute.FormAction(value));

		public HtmlButtonElement WithFormEncType(string value) => WithAttribute(Attribute.FormEncType(value));

		public HtmlButtonElement WithFormMethod(string value) => WithAttribute(Attribute.FormMethod(value));

		public HtmlButtonElement WithFormNoValidate() => WithAttribute(Attribute.FormNoValidate);

		public HtmlButtonElement WithFormTarget(string value) => WithAttribute(Attribute.FormTarget(value));

		public HtmlButtonElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlButtonElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlButtonElement WithValue(string value) => WithAttribute(Attribute.Value(value));

		public HtmlButtonElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlButtonElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlButtonElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlButtonElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlButtonElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlButtonElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlButtonElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlButtonElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlButtonElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlButtonElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlButtonElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
