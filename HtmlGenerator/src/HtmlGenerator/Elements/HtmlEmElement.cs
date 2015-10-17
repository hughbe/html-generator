using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlEmElement : HtmlElement 
    {
        public HtmlEmElement() : base("em", false) 
        {    
        }

        public new HtmlEmElement WithChild(HtmlElement child) => (HtmlEmElement)base.WithChild(child);
        public new HtmlEmElement WithChildren(Collection<HtmlElement> children) => (HtmlEmElement)base.WithChildren(children);

        public new HtmlEmElement WithInnerText(string innerText) => (HtmlEmElement)base.WithInnerText(innerText);

        public new HtmlEmElement WithAttribute(HtmlAttribute attribute) => (HtmlEmElement)base.WithAttribute(attribute);
        public new HtmlEmElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlEmElement)base.WithAttributes(attributes);

		public HtmlEmElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlEmElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlEmElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlEmElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlEmElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlEmElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlEmElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlEmElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlEmElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlEmElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlEmElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
