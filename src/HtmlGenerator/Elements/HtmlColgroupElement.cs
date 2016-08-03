using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlColgroupElement : HtmlElement 
    {
        public HtmlColgroupElement() : base("colgroup", false) 
        {    
        }

        public new HtmlColgroupElement WithChild(HtmlElement child) => (HtmlColgroupElement)base.WithChild(child);
        public new HtmlColgroupElement WithChildren(Collection<HtmlElement> children) => (HtmlColgroupElement)base.WithChildren(children);

        public new HtmlColgroupElement WithInnerText(string innerText) => (HtmlColgroupElement)base.WithInnerText(innerText);

        public new HtmlColgroupElement WithAttribute(HtmlAttribute attribute) => (HtmlColgroupElement)base.WithAttribute(attribute);
        public new HtmlColgroupElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlColgroupElement)base.WithAttributes(attributes);

		public HtmlColgroupElement WithSpan(string value) => WithAttribute(Attribute.Span(value));

		public HtmlColgroupElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlColgroupElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlColgroupElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlColgroupElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlColgroupElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlColgroupElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlColgroupElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlColgroupElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlColgroupElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlColgroupElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlColgroupElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
