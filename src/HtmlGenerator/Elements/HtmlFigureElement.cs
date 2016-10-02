using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlFigureElement : HtmlElement
    {
        public HtmlFigureElement() : base("figure", false) 
        {    
        }

        public new HtmlFigureElement WithElement(HtmlElement element) => (HtmlFigureElement)base.WithElement(element);
        public new HtmlFigureElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlFigureElement)base.WithElements(elements);

        public new HtmlFigureElement WithInnerText(string innerText) => (HtmlFigureElement)base.WithInnerText(innerText);

        public new HtmlFigureElement WithAttribute(HtmlAttribute attribute) => (HtmlFigureElement)base.WithAttribute(attribute);
        public new HtmlFigureElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlFigureElement)base.WithAttributes(attributes);

		public HtmlFigureElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlFigureElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlFigureElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlFigureElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlFigureElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlFigureElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlFigureElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlFigureElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlFigureElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlFigureElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlFigureElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
