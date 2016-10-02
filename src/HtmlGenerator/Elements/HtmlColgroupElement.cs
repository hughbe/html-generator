using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlColgroupElement : HtmlElement
    {
        public HtmlColgroupElement() : base("colgroup", false) 
        {    
        }

        public new HtmlColgroupElement WithElement(HtmlElement element) => (HtmlColgroupElement)base.WithElement(element);
        public new HtmlColgroupElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlColgroupElement)base.WithElements(elements);

        public new HtmlColgroupElement WithInnerText(string innerText) => (HtmlColgroupElement)base.WithInnerText(innerText);

        public new HtmlColgroupElement WithAttribute(HtmlAttribute attribute) => (HtmlColgroupElement)base.WithAttribute(attribute);
        public new HtmlColgroupElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlColgroupElement)base.WithAttributes(attributes);

		public HtmlColgroupElement WithSpan(string value) => WithAttribute(Attribute.Span(value));

		public HtmlColgroupElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlColgroupElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlColgroupElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlColgroupElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlColgroupElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlColgroupElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlColgroupElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlColgroupElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlColgroupElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlColgroupElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlColgroupElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
