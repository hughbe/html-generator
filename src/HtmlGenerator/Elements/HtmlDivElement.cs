using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlDivElement : HtmlElement
    {
        public HtmlDivElement() : base("div", false) 
        {    
        }

        public new HtmlDivElement WithElement(HtmlElement element) => (HtmlDivElement)base.WithElement(element);
        public new HtmlDivElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlDivElement)base.WithElements(elements);

        public new HtmlDivElement WithInnerText(string innerText) => (HtmlDivElement)base.WithInnerText(innerText);

        public new HtmlDivElement WithAttribute(HtmlAttribute attribute) => (HtmlDivElement)base.WithAttribute(attribute);
        public new HtmlDivElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlDivElement)base.WithAttributes(attributes);

		public HtmlDivElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDivElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDivElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDivElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDivElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDivElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDivElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDivElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDivElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDivElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDivElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
