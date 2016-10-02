using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlTemplateElement : HtmlElement
    {
        public HtmlTemplateElement() : base("template", false) 
        {    
        }

        public new HtmlTemplateElement WithElement(HtmlElement element) => (HtmlTemplateElement)base.WithElement(element);
        public new HtmlTemplateElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlTemplateElement)base.WithElements(elements);

        public new HtmlTemplateElement WithInnerText(string innerText) => (HtmlTemplateElement)base.WithInnerText(innerText);

        public new HtmlTemplateElement WithAttribute(HtmlAttribute attribute) => (HtmlTemplateElement)base.WithAttribute(attribute);
        public new HtmlTemplateElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlTemplateElement)base.WithAttributes(attributes);

		public HtmlTemplateElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlTemplateElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlTemplateElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlTemplateElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlTemplateElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlTemplateElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlTemplateElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlTemplateElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlTemplateElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlTemplateElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlTemplateElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
