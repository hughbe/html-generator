using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlHrElement : HtmlElement
    {
        public HtmlHrElement() : base("hr", true) 
        {    
        }

        public new HtmlHrElement WithElement(HtmlElement element) => (HtmlHrElement)base.WithElement(element);
        public new HtmlHrElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlHrElement)base.WithElements(elements);

        public new HtmlHrElement WithInnerText(string innerText) => (HtmlHrElement)base.WithInnerText(innerText);

        public new HtmlHrElement WithAttribute(HtmlAttribute attribute) => (HtmlHrElement)base.WithAttribute(attribute);
        public new HtmlHrElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlHrElement)base.WithAttributes(attributes);

		public HtmlHrElement WithColor(string value) => WithAttribute(Attribute.Color(value));

		public HtmlHrElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlHrElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlHrElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlHrElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlHrElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlHrElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlHrElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlHrElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlHrElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlHrElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlHrElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
