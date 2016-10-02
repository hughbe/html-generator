using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlSmallElement : HtmlElement
    {
        public HtmlSmallElement() : base("small", false) 
        {    
        }

        public new HtmlSmallElement WithElement(HtmlElement element) => (HtmlSmallElement)base.WithElement(element);
        public new HtmlSmallElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlSmallElement)base.WithElements(elements);

        public new HtmlSmallElement WithInnerText(string innerText) => (HtmlSmallElement)base.WithInnerText(innerText);

        public new HtmlSmallElement WithAttribute(HtmlAttribute attribute) => (HtmlSmallElement)base.WithAttribute(attribute);
        public new HtmlSmallElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlSmallElement)base.WithAttributes(attributes);

		public HtmlSmallElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlSmallElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlSmallElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlSmallElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlSmallElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlSmallElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlSmallElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlSmallElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlSmallElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlSmallElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlSmallElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
