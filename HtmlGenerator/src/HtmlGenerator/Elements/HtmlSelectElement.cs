using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlSelectElement : HtmlElement 
    {
        public HtmlSelectElement() : base("select", false) 
        {    
        }

        public new HtmlSelectElement WithChild(HtmlElement child) => (HtmlSelectElement)base.WithChild(child);
        public new HtmlSelectElement WithChildren(Collection<HtmlElement> children) => (HtmlSelectElement)base.WithChildren(children);

        public new HtmlSelectElement WithInnerText(string innerText) => (HtmlSelectElement)base.WithInnerText(innerText);

        public new HtmlSelectElement WithAttribute(HtmlAttribute attribute) => (HtmlSelectElement)base.WithAttribute(attribute);
        public new HtmlSelectElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlSelectElement)base.WithAttributes(attributes);

		public HtmlSelectElement WithAutoFocus() => WithAttribute(Attribute.AutoFocus);

		public HtmlSelectElement WithDisabled() => WithAttribute(Attribute.Disabled);

		public HtmlSelectElement WithForm(string value) => WithAttribute(Attribute.Form(value));

		public HtmlSelectElement WithMultiple() => WithAttribute(Attribute.Multiple);

		public HtmlSelectElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlSelectElement WithRequired() => WithAttribute(Attribute.Required);

		public HtmlSelectElement WithSize(string value) => WithAttribute(Attribute.Size(value));

		public HtmlSelectElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlSelectElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlSelectElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlSelectElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlSelectElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlSelectElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlSelectElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlSelectElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlSelectElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlSelectElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlSelectElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
