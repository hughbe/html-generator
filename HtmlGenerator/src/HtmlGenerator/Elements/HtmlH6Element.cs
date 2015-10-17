using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlH6Element : HtmlElement 
    {
        public HtmlH6Element() : base("h6", false) 
        {    
        }

        public new HtmlH6Element WithChild(HtmlElement child) => (HtmlH6Element)base.WithChild(child);
        public new HtmlH6Element WithChildren(Collection<HtmlElement> children) => (HtmlH6Element)base.WithChildren(children);

        public new HtmlH6Element WithInnerText(string innerText) => (HtmlH6Element)base.WithInnerText(innerText);

        public new HtmlH6Element WithAttribute(HtmlAttribute attribute) => (HtmlH6Element)base.WithAttribute(attribute);
        public new HtmlH6Element WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlH6Element)base.WithAttributes(attributes);

		public HtmlH6Element WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlH6Element WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlH6Element WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlH6Element WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlH6Element WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlH6Element WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlH6Element WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlH6Element WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlH6Element WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlH6Element WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlH6Element WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
