using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlRtcElement : HtmlElement
    {
        public HtmlRtcElement() : base("rtc", false) 
        {    
        }

        public new HtmlRtcElement WithElement(HtmlElement element) => (HtmlRtcElement)base.WithElement(element);
        public new HtmlRtcElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlRtcElement)base.WithElements(elements);

        public new HtmlRtcElement WithInnerText(string innerText) => (HtmlRtcElement)base.WithInnerText(innerText);

        public new HtmlRtcElement WithAttribute(HtmlAttribute attribute) => (HtmlRtcElement)base.WithAttribute(attribute);
        public new HtmlRtcElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlRtcElement)base.WithAttributes(attributes);

		public HtmlRtcElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlRtcElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlRtcElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlRtcElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlRtcElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlRtcElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlRtcElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlRtcElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlRtcElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlRtcElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlRtcElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
