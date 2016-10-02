using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlNoscriptElement : HtmlElement
    {
        public HtmlNoscriptElement() : base("noscript", false) 
        {    
        }

        public new HtmlNoscriptElement WithElement(HtmlElement element) => (HtmlNoscriptElement)base.WithElement(element);
        public new HtmlNoscriptElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlNoscriptElement)base.WithElements(elements);

        public new HtmlNoscriptElement WithInnerText(string innerText) => (HtmlNoscriptElement)base.WithInnerText(innerText);

        public new HtmlNoscriptElement WithAttribute(HtmlAttribute attribute) => (HtmlNoscriptElement)base.WithAttribute(attribute);
        public new HtmlNoscriptElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlNoscriptElement)base.WithAttributes(attributes);

		public HtmlNoscriptElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlNoscriptElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlNoscriptElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlNoscriptElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlNoscriptElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlNoscriptElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlNoscriptElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlNoscriptElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlNoscriptElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlNoscriptElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlNoscriptElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
