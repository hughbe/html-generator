using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlTitleElement : HtmlElement
    {
        public HtmlTitleElement() : base("title", false) 
        {    
        }

        public new HtmlTitleElement WithElement(HtmlElement element) => (HtmlTitleElement)base.WithElement(element);
        public new HtmlTitleElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlTitleElement)base.WithElements(elements);

        public new HtmlTitleElement WithInnerText(string innerText) => (HtmlTitleElement)base.WithInnerText(innerText);

        public new HtmlTitleElement WithAttribute(HtmlAttribute attribute) => (HtmlTitleElement)base.WithAttribute(attribute);
        public new HtmlTitleElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlTitleElement)base.WithAttributes(attributes);

		public HtmlTitleElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlTitleElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlTitleElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlTitleElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlTitleElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlTitleElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlTitleElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlTitleElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlTitleElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlTitleElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlTitleElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
