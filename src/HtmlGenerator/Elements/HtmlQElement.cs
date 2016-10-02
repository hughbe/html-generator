using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlQElement : HtmlElement
    {
        public HtmlQElement() : base("q", false) 
        {    
        }

        public new HtmlQElement WithElement(HtmlElement element) => (HtmlQElement)base.WithElement(element);
        public new HtmlQElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlQElement)base.WithElements(elements);

        public new HtmlQElement WithInnerText(string innerText) => (HtmlQElement)base.WithInnerText(innerText);

        public new HtmlQElement WithAttribute(HtmlAttribute attribute) => (HtmlQElement)base.WithAttribute(attribute);
        public new HtmlQElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlQElement)base.WithAttributes(attributes);

		public HtmlQElement WithCite(string value) => WithAttribute(Attribute.Cite(value));

		public HtmlQElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlQElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlQElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlQElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlQElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlQElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlQElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlQElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlQElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlQElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlQElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
