using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlOutputElement : HtmlElement
    {
        public HtmlOutputElement() : base("output", false) 
        {    
        }

        public new HtmlOutputElement WithElement(HtmlElement element) => (HtmlOutputElement)base.WithElement(element);
        public new HtmlOutputElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlOutputElement)base.WithElements(elements);

        public new HtmlOutputElement WithInnerText(string innerText) => (HtmlOutputElement)base.WithInnerText(innerText);

        public new HtmlOutputElement WithAttribute(HtmlAttribute attribute) => (HtmlOutputElement)base.WithAttribute(attribute);
        public new HtmlOutputElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlOutputElement)base.WithAttributes(attributes);

		public HtmlOutputElement WithFor(string value) => WithAttribute(Attribute.For(value));

		public HtmlOutputElement WithForm(string value) => WithAttribute(Attribute.Form(value));

		public HtmlOutputElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlOutputElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlOutputElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlOutputElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlOutputElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlOutputElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlOutputElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlOutputElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlOutputElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlOutputElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlOutputElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlOutputElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
