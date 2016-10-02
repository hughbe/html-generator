using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlFieldsetElement : HtmlElement
    {
        public HtmlFieldsetElement() : base("fieldset", false) 
        {    
        }

        public new HtmlFieldsetElement WithElement(HtmlElement element) => (HtmlFieldsetElement)base.WithElement(element);
        public new HtmlFieldsetElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlFieldsetElement)base.WithElements(elements);

        public new HtmlFieldsetElement WithInnerText(string innerText) => (HtmlFieldsetElement)base.WithInnerText(innerText);

        public new HtmlFieldsetElement WithAttribute(HtmlAttribute attribute) => (HtmlFieldsetElement)base.WithAttribute(attribute);
        public new HtmlFieldsetElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlFieldsetElement)base.WithAttributes(attributes);

		public HtmlFieldsetElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlFieldsetElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlFieldsetElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlFieldsetElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlFieldsetElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlFieldsetElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlFieldsetElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlFieldsetElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlFieldsetElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlFieldsetElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlFieldsetElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
