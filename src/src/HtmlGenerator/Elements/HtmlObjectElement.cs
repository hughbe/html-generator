using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlObjectElement : HtmlElement 
    {
        public HtmlObjectElement() : base("object", false) 
        {    
        }

        public new HtmlObjectElement WithChild(HtmlElement child) => (HtmlObjectElement)base.WithChild(child);
        public new HtmlObjectElement WithChildren(Collection<HtmlElement> children) => (HtmlObjectElement)base.WithChildren(children);

        public new HtmlObjectElement WithInnerText(string innerText) => (HtmlObjectElement)base.WithInnerText(innerText);

        public new HtmlObjectElement WithAttribute(HtmlAttribute attribute) => (HtmlObjectElement)base.WithAttribute(attribute);
        public new HtmlObjectElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlObjectElement)base.WithAttributes(attributes);

		public HtmlObjectElement WithData(string value) => WithAttribute(Attribute.Data(value));

		public HtmlObjectElement WithForm(string value) => WithAttribute(Attribute.Form(value));

		public HtmlObjectElement WithHeight(string value) => WithAttribute(Attribute.Height(value));

		public HtmlObjectElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlObjectElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlObjectElement WithTypeMustMatch() => WithAttribute(Attribute.TypeMustMatch);

		public HtmlObjectElement WithUseMap(string value) => WithAttribute(Attribute.UseMap(value));

		public HtmlObjectElement WithWidth(string value) => WithAttribute(Attribute.Width(value));

		public HtmlObjectElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlObjectElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlObjectElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlObjectElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlObjectElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlObjectElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlObjectElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlObjectElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlObjectElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlObjectElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlObjectElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
