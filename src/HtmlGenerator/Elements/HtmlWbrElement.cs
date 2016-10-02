using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlWbrElement : HtmlElement
    {
        public HtmlWbrElement() : base("wbr", false) 
        {    
        }

        public new HtmlWbrElement WithElement(HtmlElement element) => (HtmlWbrElement)base.WithElement(element);
        public new HtmlWbrElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlWbrElement)base.WithElements(elements);

        public new HtmlWbrElement WithInnerText(string innerText) => (HtmlWbrElement)base.WithInnerText(innerText);

        public new HtmlWbrElement WithAttribute(HtmlAttribute attribute) => (HtmlWbrElement)base.WithAttribute(attribute);
        public new HtmlWbrElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlWbrElement)base.WithAttributes(attributes);

		public HtmlWbrElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlWbrElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlWbrElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlWbrElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlWbrElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlWbrElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlWbrElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlWbrElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlWbrElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlWbrElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlWbrElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
