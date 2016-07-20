using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlTdElement : HtmlElement
    {
        public HtmlTdElement() : base("td", false)
        {
        }

        public new HtmlTdElement WithChild(HtmlElement child) => (HtmlTdElement)base.WithChild(child);
        public new HtmlTdElement WithChildren(Collection<HtmlElement> children) => (HtmlTdElement)base.WithChildren(children);

        public new HtmlTdElement WithInnerText(string innerText) => (HtmlTdElement)base.WithInnerText(innerText);

        public new HtmlTdElement WithAttribute(HtmlAttribute attribute) => (HtmlTdElement)base.WithAttribute(attribute);
        public new HtmlTdElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlTdElement)base.WithAttributes(attributes);

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
