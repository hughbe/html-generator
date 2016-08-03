using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlPreElement : HtmlElement 
    {
        public HtmlPreElement() : base("pre", false) 
        {    
        }

        public new HtmlPreElement WithChild(HtmlElement child) => (HtmlPreElement)base.WithChild(child);
        public new HtmlPreElement WithChildren(Collection<HtmlElement> children) => (HtmlPreElement)base.WithChildren(children);

        public new HtmlPreElement WithInnerText(string innerText) => (HtmlPreElement)base.WithInnerText(innerText);

        public new HtmlPreElement WithAttribute(HtmlAttribute attribute) => (HtmlPreElement)base.WithAttribute(attribute);
        public new HtmlPreElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlPreElement)base.WithAttributes(attributes);

		public HtmlPreElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlPreElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlPreElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlPreElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlPreElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlPreElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlPreElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlPreElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlPreElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlPreElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlPreElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
