using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlColElement : HtmlElement 
    {
        public HtmlColElement() : base("col", true) 
        {    
        }

        public new HtmlColElement WithChild(HtmlElement child) => (HtmlColElement)base.WithChild(child);
        public new HtmlColElement WithChildren(Collection<HtmlElement> children) => (HtmlColElement)base.WithChildren(children);

        public new HtmlColElement WithInnerText(string innerText) => (HtmlColElement)base.WithInnerText(innerText);

        public new HtmlColElement WithAttribute(HtmlAttribute attribute) => (HtmlColElement)base.WithAttribute(attribute);
        public new HtmlColElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlColElement)base.WithAttributes(attributes);

		public HtmlColElement WithSpan(string value) => WithAttribute(Attribute.Span(value));

		public HtmlColElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlColElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlColElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlColElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlColElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlColElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlColElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlColElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlColElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlColElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlColElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
