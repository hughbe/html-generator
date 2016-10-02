using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlMenuElement : HtmlElement
    {
        public HtmlMenuElement() : base("menu", false) 
        {    
        }

        public new HtmlMenuElement WithElement(HtmlElement element) => (HtmlMenuElement)base.WithElement(element);
        public new HtmlMenuElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlMenuElement)base.WithElements(elements);

        public new HtmlMenuElement WithInnerText(string innerText) => (HtmlMenuElement)base.WithInnerText(innerText);

        public new HtmlMenuElement WithAttribute(HtmlAttribute attribute) => (HtmlMenuElement)base.WithAttribute(attribute);
        public new HtmlMenuElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlMenuElement)base.WithAttributes(attributes);

		public HtmlMenuElement WithLabel(string value) => WithAttribute(Attribute.Label(value));

		public HtmlMenuElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlMenuElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlMenuElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlMenuElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlMenuElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlMenuElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlMenuElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlMenuElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlMenuElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlMenuElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlMenuElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlMenuElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
