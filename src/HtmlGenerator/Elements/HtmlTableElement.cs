using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlTableElement : HtmlElement
    {
        public HtmlTableElement() : base("table", false) 
        {    
        }

        public new HtmlTableElement WithElement(HtmlElement element) => (HtmlTableElement)base.WithElement(element);
        public new HtmlTableElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlTableElement)base.WithElements(elements);

        public new HtmlTableElement WithInnerText(string innerText) => (HtmlTableElement)base.WithInnerText(innerText);

        public new HtmlTableElement WithAttribute(HtmlAttribute attribute) => (HtmlTableElement)base.WithAttribute(attribute);
        public new HtmlTableElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlTableElement)base.WithAttributes(attributes);

		public HtmlTableElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlTableElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlTableElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlTableElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlTableElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlTableElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlTableElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlTableElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlTableElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlTableElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlTableElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
