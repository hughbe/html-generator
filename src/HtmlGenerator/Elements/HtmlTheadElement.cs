using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlTheadElement : HtmlElement
    {
        public HtmlTheadElement() : base("thead", false) 
        {    
        }

        public new HtmlTheadElement WithElement(HtmlElement element) => (HtmlTheadElement)base.WithElement(element);
        public new HtmlTheadElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlTheadElement)base.WithElements(elements);

        public new HtmlTheadElement WithInnerText(string innerText) => (HtmlTheadElement)base.WithInnerText(innerText);

        public new HtmlTheadElement WithAttribute(HtmlAttribute attribute) => (HtmlTheadElement)base.WithAttribute(attribute);
        public new HtmlTheadElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlTheadElement)base.WithAttributes(attributes);

		public HtmlTheadElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlTheadElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlTheadElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlTheadElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlTheadElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlTheadElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlTheadElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlTheadElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlTheadElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlTheadElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlTheadElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
