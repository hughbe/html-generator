using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlSectionElement : HtmlElement
    {
        public HtmlSectionElement() : base("section", false) 
        {    
        }

        public new HtmlSectionElement WithElement(HtmlElement element) => (HtmlSectionElement)base.WithElement(element);
        public new HtmlSectionElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlSectionElement)base.WithElements(elements);

        public new HtmlSectionElement WithInnerText(string innerText) => (HtmlSectionElement)base.WithInnerText(innerText);

        public new HtmlSectionElement WithAttribute(HtmlAttribute attribute) => (HtmlSectionElement)base.WithAttribute(attribute);
        public new HtmlSectionElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlSectionElement)base.WithAttributes(attributes);

		public HtmlSectionElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlSectionElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlSectionElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlSectionElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlSectionElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlSectionElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlSectionElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlSectionElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlSectionElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlSectionElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlSectionElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
