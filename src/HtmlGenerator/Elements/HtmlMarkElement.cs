using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlMarkElement : HtmlElement
    {
        public HtmlMarkElement() : base("mark", false) 
        {    
        }

        public new HtmlMarkElement WithElement(HtmlElement element) => (HtmlMarkElement)base.WithElement(element);
        public new HtmlMarkElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlMarkElement)base.WithElements(elements);

        public new HtmlMarkElement WithInnerText(string innerText) => (HtmlMarkElement)base.WithInnerText(innerText);

        public new HtmlMarkElement WithAttribute(HtmlAttribute attribute) => (HtmlMarkElement)base.WithAttribute(attribute);
        public new HtmlMarkElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlMarkElement)base.WithAttributes(attributes);

		public HtmlMarkElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlMarkElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlMarkElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlMarkElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlMarkElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlMarkElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlMarkElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlMarkElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlMarkElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlMarkElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlMarkElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
