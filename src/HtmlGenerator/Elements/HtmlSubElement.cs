using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlSubElement : HtmlElement
    {
        public HtmlSubElement() : base("sub", false) 
        {    
        }

        public new HtmlSubElement WithElement(HtmlElement element) => (HtmlSubElement)base.WithElement(element);
        public new HtmlSubElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlSubElement)base.WithElements(elements);

        public new HtmlSubElement WithInnerText(string innerText) => (HtmlSubElement)base.WithInnerText(innerText);

        public new HtmlSubElement WithAttribute(HtmlAttribute attribute) => (HtmlSubElement)base.WithAttribute(attribute);
        public new HtmlSubElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlSubElement)base.WithAttributes(attributes);

		public HtmlSubElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlSubElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlSubElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlSubElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlSubElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlSubElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlSubElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlSubElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlSubElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlSubElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlSubElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
