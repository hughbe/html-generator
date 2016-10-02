using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlHeaderElement : HtmlElement
    {
        public HtmlHeaderElement() : base("header", false) 
        {    
        }

        public new HtmlHeaderElement WithElement(HtmlElement element) => (HtmlHeaderElement)base.WithElement(element);
        public new HtmlHeaderElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlHeaderElement)base.WithElements(elements);

        public new HtmlHeaderElement WithInnerText(string innerText) => (HtmlHeaderElement)base.WithInnerText(innerText);

        public new HtmlHeaderElement WithAttribute(HtmlAttribute attribute) => (HtmlHeaderElement)base.WithAttribute(attribute);
        public new HtmlHeaderElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlHeaderElement)base.WithAttributes(attributes);

		public HtmlHeaderElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlHeaderElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlHeaderElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlHeaderElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlHeaderElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlHeaderElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlHeaderElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlHeaderElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlHeaderElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlHeaderElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlHeaderElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
