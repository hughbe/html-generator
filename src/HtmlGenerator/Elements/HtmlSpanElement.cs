using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlSpanElement : HtmlElement 
    {
        public HtmlSpanElement() : base("span", false) 
        {    
        }

        public new HtmlSpanElement WithChild(HtmlElement child) => (HtmlSpanElement)base.WithChild(child);
        public new HtmlSpanElement WithChildren(Collection<HtmlElement> children) => (HtmlSpanElement)base.WithChildren(children);

        public new HtmlSpanElement WithInnerText(string innerText) => (HtmlSpanElement)base.WithInnerText(innerText);

        public new HtmlSpanElement WithAttribute(HtmlAttribute attribute) => (HtmlSpanElement)base.WithAttribute(attribute);
        public new HtmlSpanElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlSpanElement)base.WithAttributes(attributes);

		public HtmlSpanElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlSpanElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlSpanElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlSpanElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlSpanElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlSpanElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlSpanElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlSpanElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlSpanElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlSpanElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlSpanElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
