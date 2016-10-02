using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlTimeElement : HtmlElement
    {
        public HtmlTimeElement() : base("time", false) 
        {    
        }

        public new HtmlTimeElement WithElement(HtmlElement element) => (HtmlTimeElement)base.WithElement(element);
        public new HtmlTimeElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlTimeElement)base.WithElements(elements);

        public new HtmlTimeElement WithInnerText(string innerText) => (HtmlTimeElement)base.WithInnerText(innerText);

        public new HtmlTimeElement WithAttribute(HtmlAttribute attribute) => (HtmlTimeElement)base.WithAttribute(attribute);
        public new HtmlTimeElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlTimeElement)base.WithAttributes(attributes);

		public HtmlTimeElement WithDateTime(string value) => WithAttribute(Attribute.DateTime(value));

		public HtmlTimeElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlTimeElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlTimeElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlTimeElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlTimeElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlTimeElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlTimeElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlTimeElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlTimeElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlTimeElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlTimeElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
