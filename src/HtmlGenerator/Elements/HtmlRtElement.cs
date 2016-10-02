using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlRtElement : HtmlElement
    {
        public HtmlRtElement() : base("rt", false) 
        {    
        }

        public new HtmlRtElement WithElement(HtmlElement element) => (HtmlRtElement)base.WithElement(element);
        public new HtmlRtElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlRtElement)base.WithElements(elements);

        public new HtmlRtElement WithInnerText(string innerText) => (HtmlRtElement)base.WithInnerText(innerText);

        public new HtmlRtElement WithAttribute(HtmlAttribute attribute) => (HtmlRtElement)base.WithAttribute(attribute);
        public new HtmlRtElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlRtElement)base.WithAttributes(attributes);

		public HtmlRtElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlRtElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlRtElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlRtElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlRtElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlRtElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlRtElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlRtElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlRtElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlRtElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlRtElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
