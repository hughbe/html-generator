using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlDlElement : HtmlElement
    {
        public HtmlDlElement() : base("dl", false) 
        {    
        }

        public new HtmlDlElement WithElement(HtmlElement element) => (HtmlDlElement)base.WithElement(element);
        public new HtmlDlElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlDlElement)base.WithElements(elements);

        public new HtmlDlElement WithInnerText(string innerText) => (HtmlDlElement)base.WithInnerText(innerText);

        public new HtmlDlElement WithAttribute(HtmlAttribute attribute) => (HtmlDlElement)base.WithAttribute(attribute);
        public new HtmlDlElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlDlElement)base.WithAttributes(attributes);

		public HtmlDlElement WithCompact(string value) => WithAttribute(Attribute.Compact(value));

		public HtmlDlElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDlElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDlElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDlElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDlElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDlElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDlElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDlElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDlElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDlElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDlElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
