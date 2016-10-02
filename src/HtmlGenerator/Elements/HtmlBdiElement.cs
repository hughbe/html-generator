using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlBdiElement : HtmlElement
    {
        public HtmlBdiElement() : base("bdi", false) 
        {    
        }

        public new HtmlBdiElement WithElement(HtmlElement element) => (HtmlBdiElement)base.WithElement(element);
        public new HtmlBdiElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlBdiElement)base.WithElements(elements);

        public new HtmlBdiElement WithInnerText(string innerText) => (HtmlBdiElement)base.WithInnerText(innerText);

        public new HtmlBdiElement WithAttribute(HtmlAttribute attribute) => (HtmlBdiElement)base.WithAttribute(attribute);
        public new HtmlBdiElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlBdiElement)base.WithAttributes(attributes);

		public HtmlBdiElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlBdiElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlBdiElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlBdiElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlBdiElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlBdiElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlBdiElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlBdiElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlBdiElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlBdiElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlBdiElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
