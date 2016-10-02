using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlVarElement : HtmlElement
    {
        public HtmlVarElement() : base("var", false) 
        {    
        }

        public new HtmlVarElement WithElement(HtmlElement element) => (HtmlVarElement)base.WithElement(element);
        public new HtmlVarElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlVarElement)base.WithElements(elements);

        public new HtmlVarElement WithInnerText(string innerText) => (HtmlVarElement)base.WithInnerText(innerText);

        public new HtmlVarElement WithAttribute(HtmlAttribute attribute) => (HtmlVarElement)base.WithAttribute(attribute);
        public new HtmlVarElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlVarElement)base.WithAttributes(attributes);

		public HtmlVarElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlVarElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlVarElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlVarElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlVarElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlVarElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlVarElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlVarElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlVarElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlVarElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlVarElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
