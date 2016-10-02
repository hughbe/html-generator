using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlBaseElement : HtmlElement
    {
        public HtmlBaseElement() : base("base", true) 
        {    
        }

        public new HtmlBaseElement WithElement(HtmlElement element) => (HtmlBaseElement)base.WithElement(element);
        public new HtmlBaseElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlBaseElement)base.WithElements(elements);

        public new HtmlBaseElement WithInnerText(string innerText) => (HtmlBaseElement)base.WithInnerText(innerText);

        public new HtmlBaseElement WithAttribute(HtmlAttribute attribute) => (HtmlBaseElement)base.WithAttribute(attribute);
        public new HtmlBaseElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlBaseElement)base.WithAttributes(attributes);

		public HtmlBaseElement WithHref(string value) => WithAttribute(Attribute.Href(value));

		public HtmlBaseElement WithTarget(string value) => WithAttribute(Attribute.Target(value));

		public HtmlBaseElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlBaseElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlBaseElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlBaseElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlBaseElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlBaseElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlBaseElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlBaseElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlBaseElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlBaseElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlBaseElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
