using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlAddressElement : HtmlElement
    {
        public HtmlAddressElement() : base("address", false) 
        {    
        }

        public new HtmlAddressElement WithElement(HtmlElement element) => (HtmlAddressElement)base.WithElement(element);
        public new HtmlAddressElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlAddressElement)base.WithElements(elements);

        public new HtmlAddressElement WithInnerText(string innerText) => (HtmlAddressElement)base.WithInnerText(innerText);

        public new HtmlAddressElement WithAttribute(HtmlAttribute attribute) => (HtmlAddressElement)base.WithAttribute(attribute);
        public new HtmlAddressElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlAddressElement)base.WithAttributes(attributes);

		public HtmlAddressElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlAddressElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlAddressElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlAddressElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlAddressElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlAddressElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlAddressElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlAddressElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlAddressElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlAddressElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlAddressElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
