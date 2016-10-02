using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlTbodyElement : HtmlElement
    {
        public HtmlTbodyElement() : base("tbody", false) 
        {    
        }

        public new HtmlTbodyElement WithElement(HtmlElement element) => (HtmlTbodyElement)base.WithElement(element);
        public new HtmlTbodyElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlTbodyElement)base.WithElements(elements);

        public new HtmlTbodyElement WithInnerText(string innerText) => (HtmlTbodyElement)base.WithInnerText(innerText);

        public new HtmlTbodyElement WithAttribute(HtmlAttribute attribute) => (HtmlTbodyElement)base.WithAttribute(attribute);
        public new HtmlTbodyElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlTbodyElement)base.WithAttributes(attributes);

		public HtmlTbodyElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlTbodyElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlTbodyElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlTbodyElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlTbodyElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlTbodyElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlTbodyElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlTbodyElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlTbodyElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlTbodyElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlTbodyElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
