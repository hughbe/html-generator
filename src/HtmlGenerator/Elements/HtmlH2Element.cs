using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlH2Element : HtmlElement
    {
        public HtmlH2Element() : base("h2", false) 
        {    
        }

        public new HtmlH2Element WithElement(HtmlElement element) => (HtmlH2Element)base.WithElement(element);
        public new HtmlH2Element WithElements(IEnumerable<HtmlElement> elements) => (HtmlH2Element)base.WithElements(elements);

        public new HtmlH2Element WithInnerText(string innerText) => (HtmlH2Element)base.WithInnerText(innerText);

        public new HtmlH2Element WithAttribute(HtmlAttribute attribute) => (HtmlH2Element)base.WithAttribute(attribute);
        public new HtmlH2Element WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlH2Element)base.WithAttributes(attributes);

		public HtmlH2Element WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlH2Element WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlH2Element WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlH2Element WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlH2Element WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlH2Element WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlH2Element WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlH2Element WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlH2Element WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlH2Element WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlH2Element WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
