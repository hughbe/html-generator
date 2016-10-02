using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlH5Element : HtmlElement
    {
        public HtmlH5Element() : base("h5", false) 
        {    
        }

        public new HtmlH5Element WithElement(HtmlElement element) => (HtmlH5Element)base.WithElement(element);
        public new HtmlH5Element WithElements(IEnumerable<HtmlElement> elements) => (HtmlH5Element)base.WithElements(elements);

        public new HtmlH5Element WithInnerText(string innerText) => (HtmlH5Element)base.WithInnerText(innerText);

        public new HtmlH5Element WithAttribute(HtmlAttribute attribute) => (HtmlH5Element)base.WithAttribute(attribute);
        public new HtmlH5Element WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlH5Element)base.WithAttributes(attributes);

		public HtmlH5Element WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlH5Element WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlH5Element WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlH5Element WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlH5Element WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlH5Element WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlH5Element WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlH5Element WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlH5Element WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlH5Element WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlH5Element WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
