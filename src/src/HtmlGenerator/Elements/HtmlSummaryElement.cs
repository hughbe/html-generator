using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlSummaryElement : HtmlElement 
    {
        public HtmlSummaryElement() : base("summary", false) 
        {    
        }

        public new HtmlSummaryElement WithChild(HtmlElement child) => (HtmlSummaryElement)base.WithChild(child);
        public new HtmlSummaryElement WithChildren(Collection<HtmlElement> children) => (HtmlSummaryElement)base.WithChildren(children);

        public new HtmlSummaryElement WithInnerText(string innerText) => (HtmlSummaryElement)base.WithInnerText(innerText);

        public new HtmlSummaryElement WithAttribute(HtmlAttribute attribute) => (HtmlSummaryElement)base.WithAttribute(attribute);
        public new HtmlSummaryElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlSummaryElement)base.WithAttributes(attributes);

		public HtmlSummaryElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlSummaryElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlSummaryElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlSummaryElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlSummaryElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlSummaryElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlSummaryElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlSummaryElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlSummaryElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlSummaryElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlSummaryElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
