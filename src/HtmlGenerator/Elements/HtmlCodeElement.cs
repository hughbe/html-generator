using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlCodeElement : HtmlElement
    {
        public HtmlCodeElement() : base("code", false) 
        {    
        }

        public new HtmlCodeElement WithElement(HtmlElement element) => (HtmlCodeElement)base.WithElement(element);
        public new HtmlCodeElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlCodeElement)base.WithElements(elements);

        public new HtmlCodeElement WithInnerText(string innerText) => (HtmlCodeElement)base.WithInnerText(innerText);

        public new HtmlCodeElement WithAttribute(HtmlAttribute attribute) => (HtmlCodeElement)base.WithAttribute(attribute);
        public new HtmlCodeElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlCodeElement)base.WithAttributes(attributes);

		public HtmlCodeElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlCodeElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlCodeElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlCodeElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlCodeElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlCodeElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlCodeElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlCodeElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlCodeElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlCodeElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlCodeElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
