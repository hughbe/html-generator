using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlDetailsElement : HtmlElement
    {
        public HtmlDetailsElement() : base("details", false) 
        {    
        }

        public new HtmlDetailsElement WithElement(HtmlElement element) => (HtmlDetailsElement)base.WithElement(element);
        public new HtmlDetailsElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlDetailsElement)base.WithElements(elements);

        public new HtmlDetailsElement WithInnerText(string innerText) => (HtmlDetailsElement)base.WithInnerText(innerText);

        public new HtmlDetailsElement WithAttribute(HtmlAttribute attribute) => (HtmlDetailsElement)base.WithAttribute(attribute);
        public new HtmlDetailsElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlDetailsElement)base.WithAttributes(attributes);

		public HtmlDetailsElement WithOpen(string value) => WithAttribute(Attribute.Open(value));

		public HtmlDetailsElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDetailsElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDetailsElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDetailsElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDetailsElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDetailsElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDetailsElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDetailsElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDetailsElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDetailsElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDetailsElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
