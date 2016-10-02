using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlTdElement : HtmlElement
    {
        public HtmlTdElement() : base("td", false)
        {
        }

        public new HtmlTdElement WithElement(HtmlElement child) => (HtmlTdElement)base.WithElement(child);
        public new HtmlTdElement WithElements(IEnumerable<HtmlElement> children) => (HtmlTdElement)base.WithElements(children);

        public new HtmlTdElement WithInnerText(string innerText) => (HtmlTdElement)base.WithInnerText(innerText);

        public new HtmlTdElement WithAttribute(HtmlAttribute attribute) => (HtmlTdElement)base.WithAttribute(attribute);
        public new HtmlTdElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlTdElement)base.WithAttributes(attributes);

        public HtmlTdElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

        public HtmlTdElement WithClass(string value) => WithAttribute(Attribute.Class(value));

        public HtmlTdElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

        public HtmlTdElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

        public HtmlTdElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

        public HtmlTdElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

        public HtmlTdElement WithId(string value) => WithAttribute(Attribute.Id(value));

        public HtmlTdElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

        public HtmlTdElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

        public HtmlTdElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

        public HtmlTdElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
