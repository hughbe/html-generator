using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlOptionElement : HtmlElement
    {
        public HtmlOptionElement() : base("option", false) 
        {    
        }

        public new HtmlOptionElement WithElement(HtmlElement element) => (HtmlOptionElement)base.WithElement(element);
        public new HtmlOptionElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlOptionElement)base.WithElements(elements);

        public new HtmlOptionElement WithInnerText(string innerText) => (HtmlOptionElement)base.WithInnerText(innerText);

        public new HtmlOptionElement WithAttribute(HtmlAttribute attribute) => (HtmlOptionElement)base.WithAttribute(attribute);
        public new HtmlOptionElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlOptionElement)base.WithAttributes(attributes);

		public HtmlOptionElement WithDisabled() => WithAttribute(Attribute.Disabled);

		public HtmlOptionElement WithLabel(string value) => WithAttribute(Attribute.Label(value));

		public HtmlOptionElement WithSelected() => WithAttribute(Attribute.Selected);

		public HtmlOptionElement WithValue(string value) => WithAttribute(Attribute.Value(value));

		public HtmlOptionElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlOptionElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlOptionElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlOptionElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlOptionElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlOptionElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlOptionElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlOptionElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlOptionElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlOptionElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlOptionElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
