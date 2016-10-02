using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlNavElement : HtmlElement
    {
        public HtmlNavElement() : base("nav", false) 
        {    
        }

        public new HtmlNavElement WithElement(HtmlElement element) => (HtmlNavElement)base.WithElement(element);
        public new HtmlNavElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlNavElement)base.WithElements(elements);

        public new HtmlNavElement WithInnerText(string innerText) => (HtmlNavElement)base.WithInnerText(innerText);

        public new HtmlNavElement WithAttribute(HtmlAttribute attribute) => (HtmlNavElement)base.WithAttribute(attribute);
        public new HtmlNavElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlNavElement)base.WithAttributes(attributes);

		public HtmlNavElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlNavElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlNavElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlNavElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlNavElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlNavElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlNavElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlNavElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlNavElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlNavElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlNavElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
