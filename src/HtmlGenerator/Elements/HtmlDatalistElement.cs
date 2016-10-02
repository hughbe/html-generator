using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlDatalistElement : HtmlElement
    {
        public HtmlDatalistElement() : base("datalist", false) 
        {    
        }

        public new HtmlDatalistElement WithElement(HtmlElement element) => (HtmlDatalistElement)base.WithElement(element);
        public new HtmlDatalistElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlDatalistElement)base.WithElements(elements);

        public new HtmlDatalistElement WithInnerText(string innerText) => (HtmlDatalistElement)base.WithInnerText(innerText);

        public new HtmlDatalistElement WithAttribute(HtmlAttribute attribute) => (HtmlDatalistElement)base.WithAttribute(attribute);
        public new HtmlDatalistElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlDatalistElement)base.WithAttributes(attributes);

		public HtmlDatalistElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDatalistElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDatalistElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDatalistElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDatalistElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDatalistElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDatalistElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDatalistElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDatalistElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDatalistElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDatalistElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
