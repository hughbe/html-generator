using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlDdElement : HtmlElement 
    {
        public HtmlDdElement() : base("dd", false) 
        {    
        }

        public new HtmlDdElement WithChild(HtmlElement child) => (HtmlDdElement)base.WithChild(child);
        public new HtmlDdElement WithChildren(Collection<HtmlElement> children) => (HtmlDdElement)base.WithChildren(children);

        public new HtmlDdElement WithInnerText(string innerText) => (HtmlDdElement)base.WithInnerText(innerText);

        public new HtmlDdElement WithAttribute(HtmlAttribute attribute) => (HtmlDdElement)base.WithAttribute(attribute);
        public new HtmlDdElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlDdElement)base.WithAttributes(attributes);

		public HtmlDdElement WithNoWrap(string value) => WithAttribute(Attribute.NoWrap(value));

		public HtmlDdElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDdElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDdElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDdElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDdElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDdElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDdElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDdElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDdElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDdElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDdElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
