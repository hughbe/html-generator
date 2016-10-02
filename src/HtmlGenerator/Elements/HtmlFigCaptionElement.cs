using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlFigCaptionElement : HtmlElement
    {
        public HtmlFigCaptionElement() : base("figcaption", false) 
        {    
        }

        public new HtmlFigCaptionElement WithElement(HtmlElement element) => (HtmlFigCaptionElement)base.WithElement(element);
        public new HtmlFigCaptionElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlFigCaptionElement)base.WithElements(elements);

        public new HtmlFigCaptionElement WithInnerText(string innerText) => (HtmlFigCaptionElement)base.WithInnerText(innerText);

        public new HtmlFigCaptionElement WithAttribute(HtmlAttribute attribute) => (HtmlFigCaptionElement)base.WithAttribute(attribute);
        public new HtmlFigCaptionElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlFigCaptionElement)base.WithAttributes(attributes);

		public HtmlFigCaptionElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlFigCaptionElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlFigCaptionElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlFigCaptionElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlFigCaptionElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlFigCaptionElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlFigCaptionElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlFigCaptionElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlFigCaptionElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlFigCaptionElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlFigCaptionElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
