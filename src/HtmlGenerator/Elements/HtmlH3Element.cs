using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlH3Element : HtmlElement
    {
        public HtmlH3Element() : base("h3", false) 
        {    
        }

        public new HtmlH3Element WithElement(HtmlElement element) => (HtmlH3Element)base.WithElement(element);
        public new HtmlH3Element WithElements(IEnumerable<HtmlElement> elements) => (HtmlH3Element)base.WithElements(elements);

        public new HtmlH3Element WithInnerText(string innerText) => (HtmlH3Element)base.WithInnerText(innerText);

        public new HtmlH3Element WithAttribute(HtmlAttribute attribute) => (HtmlH3Element)base.WithAttribute(attribute);
        public new HtmlH3Element WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlH3Element)base.WithAttributes(attributes);

		public HtmlH3Element WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlH3Element WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlH3Element WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlH3Element WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlH3Element WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlH3Element WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlH3Element WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlH3Element WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlH3Element WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlH3Element WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlH3Element WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
