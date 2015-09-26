using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlDataElement : HtmlElement 
    {
        public HtmlDataElement() : base("data", false) 
        {    
        }

        public new HtmlDataElement WithChild(HtmlElement child) => (HtmlDataElement)base.WithChild(child);
        public new HtmlDataElement WithChildren(Collection<HtmlElement> children) => (HtmlDataElement)base.WithChildren(children);

        public new HtmlDataElement WithInnerText(string innerText) => (HtmlDataElement)base.WithInnerText(innerText);

        public new HtmlDataElement WithAttribute(HtmlAttribute attribute) => (HtmlDataElement)base.WithAttribute(attribute);
        public new HtmlDataElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlDataElement)base.WithAttributes(attributes);

		public HtmlDataElement WithValue(string value) => WithAttribute(Attribute.Value(value));

		public HtmlDataElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDataElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDataElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDataElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDataElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDataElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDataElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDataElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDataElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDataElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDataElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
