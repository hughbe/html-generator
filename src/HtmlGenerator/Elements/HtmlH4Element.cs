using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlH4Element : HtmlElement
    {
        public HtmlH4Element() : base("h4", false) 
        {    
        }

        public new HtmlH4Element WithElement(HtmlElement element) => (HtmlH4Element)base.WithElement(element);
        public new HtmlH4Element WithElements(IEnumerable<HtmlElement> elements) => (HtmlH4Element)base.WithElements(elements);

        public new HtmlH4Element WithInnerText(string innerText) => (HtmlH4Element)base.WithInnerText(innerText);

        public new HtmlH4Element WithAttribute(HtmlAttribute attribute) => (HtmlH4Element)base.WithAttribute(attribute);
        public new HtmlH4Element WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlH4Element)base.WithAttributes(attributes);

		public HtmlH4Element WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlH4Element WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlH4Element WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlH4Element WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlH4Element WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlH4Element WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlH4Element WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlH4Element WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlH4Element WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlH4Element WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlH4Element WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
