using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlThElement : HtmlElement 
    {
        public HtmlThElement() : base("th", false) 
        {    
        }

        public new HtmlThElement WithChild(HtmlElement child) => (HtmlThElement)base.WithChild(child);
        public new HtmlThElement WithChildren(Collection<HtmlElement> children) => (HtmlThElement)base.WithChildren(children);

        public new HtmlThElement WithInnerText(string innerText) => (HtmlThElement)base.WithInnerText(innerText);

        public new HtmlThElement WithAttribute(HtmlAttribute attribute) => (HtmlThElement)base.WithAttribute(attribute);
        public new HtmlThElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlThElement)base.WithAttributes(attributes);

		public HtmlThElement WithColSpan(string value) => WithAttribute(Attribute.ColSpan(value));

		public HtmlThElement WithHeaders(string value) => WithAttribute(Attribute.Headers(value));

		public HtmlThElement WithRowSpan(string value) => WithAttribute(Attribute.RowSpan(value));

		public HtmlThElement WithScope(string value) => WithAttribute(Attribute.Scope(value));

		public HtmlThElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlThElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlThElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlThElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlThElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlThElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlThElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlThElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlThElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlThElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlThElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
