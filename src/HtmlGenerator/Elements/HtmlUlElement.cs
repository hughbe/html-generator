using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlUlElement : HtmlElement
    {
        public HtmlUlElement() : base("ul", false) 
        {    
        }

        public new HtmlUlElement WithElement(HtmlElement element) => (HtmlUlElement)base.WithElement(element);
        public new HtmlUlElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlUlElement)base.WithElements(elements);

        public new HtmlUlElement WithInnerText(string innerText) => (HtmlUlElement)base.WithInnerText(innerText);

        public new HtmlUlElement WithAttribute(HtmlAttribute attribute) => (HtmlUlElement)base.WithAttribute(attribute);
        public new HtmlUlElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlUlElement)base.WithAttributes(attributes);

		public HtmlUlElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlUlElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlUlElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlUlElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlUlElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlUlElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlUlElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlUlElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlUlElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlUlElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlUlElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
