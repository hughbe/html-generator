using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlBodyElement : HtmlElement
    {
        public HtmlBodyElement() : base("body", false) 
        {    
        }

        public new HtmlBodyElement WithElement(HtmlElement element) => (HtmlBodyElement)base.WithElement(element);
        public new HtmlBodyElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlBodyElement)base.WithElements(elements);

        public new HtmlBodyElement WithInnerText(string innerText) => (HtmlBodyElement)base.WithInnerText(innerText);

        public new HtmlBodyElement WithAttribute(HtmlAttribute attribute) => (HtmlBodyElement)base.WithAttribute(attribute);
        public new HtmlBodyElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlBodyElement)base.WithAttributes(attributes);

		public HtmlBodyElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlBodyElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlBodyElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlBodyElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlBodyElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlBodyElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlBodyElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlBodyElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlBodyElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlBodyElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlBodyElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
