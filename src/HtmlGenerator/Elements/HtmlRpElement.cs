using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlRpElement : HtmlElement
    {
        public HtmlRpElement() : base("rp", false) 
        {    
        }

        public new HtmlRpElement WithElement(HtmlElement element) => (HtmlRpElement)base.WithElement(element);
        public new HtmlRpElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlRpElement)base.WithElements(elements);

        public new HtmlRpElement WithInnerText(string innerText) => (HtmlRpElement)base.WithInnerText(innerText);

        public new HtmlRpElement WithAttribute(HtmlAttribute attribute) => (HtmlRpElement)base.WithAttribute(attribute);
        public new HtmlRpElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlRpElement)base.WithAttributes(attributes);

		public HtmlRpElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlRpElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlRpElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlRpElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlRpElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlRpElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlRpElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlRpElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlRpElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlRpElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlRpElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
