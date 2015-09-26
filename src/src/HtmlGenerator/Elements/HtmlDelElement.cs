using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlDelElement : HtmlElement 
    {
        public HtmlDelElement() : base("del", false) 
        {    
        }

        public new HtmlDelElement WithChild(HtmlElement child) => (HtmlDelElement)base.WithChild(child);
        public new HtmlDelElement WithChildren(Collection<HtmlElement> children) => (HtmlDelElement)base.WithChildren(children);

        public new HtmlDelElement WithInnerText(string innerText) => (HtmlDelElement)base.WithInnerText(innerText);

        public new HtmlDelElement WithAttribute(HtmlAttribute attribute) => (HtmlDelElement)base.WithAttribute(attribute);
        public new HtmlDelElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlDelElement)base.WithAttributes(attributes);

		public HtmlDelElement WithCite(string value) => WithAttribute(Attribute.Cite(value));

		public HtmlDelElement WithDateTime(string value) => WithAttribute(Attribute.DateTime(value));

		public HtmlDelElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDelElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDelElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDelElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDelElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDelElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDelElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDelElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDelElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDelElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDelElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
