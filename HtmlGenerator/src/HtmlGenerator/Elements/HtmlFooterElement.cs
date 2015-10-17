using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlFooterElement : HtmlElement 
    {
        public HtmlFooterElement() : base("footer", false) 
        {    
        }

        public new HtmlFooterElement WithChild(HtmlElement child) => (HtmlFooterElement)base.WithChild(child);
        public new HtmlFooterElement WithChildren(Collection<HtmlElement> children) => (HtmlFooterElement)base.WithChildren(children);

        public new HtmlFooterElement WithInnerText(string innerText) => (HtmlFooterElement)base.WithInnerText(innerText);

        public new HtmlFooterElement WithAttribute(HtmlAttribute attribute) => (HtmlFooterElement)base.WithAttribute(attribute);
        public new HtmlFooterElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlFooterElement)base.WithAttributes(attributes);

		public HtmlFooterElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlFooterElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlFooterElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlFooterElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlFooterElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlFooterElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlFooterElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlFooterElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlFooterElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlFooterElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlFooterElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
