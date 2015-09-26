using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlHtmlElement : HtmlElement 
    {
        public HtmlHtmlElement() : base("html", false) 
        {    
        }

        public new HtmlHtmlElement WithChild(HtmlElement child) => (HtmlHtmlElement)base.WithChild(child);
        public new HtmlHtmlElement WithChildren(Collection<HtmlElement> children) => (HtmlHtmlElement)base.WithChildren(children);

        public new HtmlHtmlElement WithInnerText(string innerText) => (HtmlHtmlElement)base.WithInnerText(innerText);

        public new HtmlHtmlElement WithAttribute(HtmlAttribute attribute) => (HtmlHtmlElement)base.WithAttribute(attribute);
        public new HtmlHtmlElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlHtmlElement)base.WithAttributes(attributes);

		public HtmlHtmlElement WithXmls(string value) => WithAttribute(Attribute.Xmls(value));

		public HtmlHtmlElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlHtmlElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlHtmlElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlHtmlElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlHtmlElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlHtmlElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlHtmlElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlHtmlElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlHtmlElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlHtmlElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlHtmlElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
