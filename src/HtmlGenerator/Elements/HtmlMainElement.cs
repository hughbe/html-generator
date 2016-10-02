using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlMainElement : HtmlElement
    {
        public HtmlMainElement() : base("main", false) 
        {    
        }

        public new HtmlMainElement WithElement(HtmlElement element) => (HtmlMainElement)base.WithElement(element);
        public new HtmlMainElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlMainElement)base.WithElements(elements);

        public new HtmlMainElement WithInnerText(string innerText) => (HtmlMainElement)base.WithInnerText(innerText);

        public new HtmlMainElement WithAttribute(HtmlAttribute attribute) => (HtmlMainElement)base.WithAttribute(attribute);
        public new HtmlMainElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlMainElement)base.WithAttributes(attributes);

		public HtmlMainElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlMainElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlMainElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlMainElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlMainElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlMainElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlMainElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlMainElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlMainElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlMainElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlMainElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
