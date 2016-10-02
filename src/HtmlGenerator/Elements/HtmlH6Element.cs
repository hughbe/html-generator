using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlH6Element : HtmlElement
    {
        public HtmlH6Element() : base("h6", false) 
        {    
        }

        public new HtmlH6Element WithElement(HtmlElement element) => (HtmlH6Element)base.WithElement(element);
        public new HtmlH6Element WithElements(IEnumerable<HtmlElement> elements) => (HtmlH6Element)base.WithElements(elements);

        public new HtmlH6Element WithInnerText(string innerText) => (HtmlH6Element)base.WithInnerText(innerText);

        public new HtmlH6Element WithAttribute(HtmlAttribute attribute) => (HtmlH6Element)base.WithAttribute(attribute);
        public new HtmlH6Element WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlH6Element)base.WithAttributes(attributes);

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
