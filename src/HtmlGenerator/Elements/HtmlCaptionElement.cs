using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlCaptionElement : HtmlElement
    {
        public HtmlCaptionElement() : base("caption", false) 
        {    
        }

        public new HtmlCaptionElement WithElement(HtmlElement element) => (HtmlCaptionElement)base.WithElement(element);
        public new HtmlCaptionElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlCaptionElement)base.WithElements(elements);

        public new HtmlCaptionElement WithInnerText(string innerText) => (HtmlCaptionElement)base.WithInnerText(innerText);

        public new HtmlCaptionElement WithAttribute(HtmlAttribute attribute) => (HtmlCaptionElement)base.WithAttribute(attribute);
        public new HtmlCaptionElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlCaptionElement)base.WithAttributes(attributes);

		public HtmlCaptionElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlCaptionElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlCaptionElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlCaptionElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlCaptionElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlCaptionElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlCaptionElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlCaptionElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlCaptionElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlCaptionElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlCaptionElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
