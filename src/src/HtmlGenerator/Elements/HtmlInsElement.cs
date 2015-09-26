using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlInsElement : HtmlElement 
    {
        public HtmlInsElement() : base("ins", false) 
        {    
        }

        public new HtmlInsElement WithChild(HtmlElement child) => (HtmlInsElement)base.WithChild(child);
        public new HtmlInsElement WithChildren(Collection<HtmlElement> children) => (HtmlInsElement)base.WithChildren(children);

        public new HtmlInsElement WithInnerText(string innerText) => (HtmlInsElement)base.WithInnerText(innerText);

        public new HtmlInsElement WithAttribute(HtmlAttribute attribute) => (HtmlInsElement)base.WithAttribute(attribute);
        public new HtmlInsElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlInsElement)base.WithAttributes(attributes);

		public HtmlInsElement WithCite(string value) => WithAttribute(Attribute.Cite(value));

		public HtmlInsElement WithDateTime(string value) => WithAttribute(Attribute.DateTime(value));

		public HtmlInsElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlInsElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlInsElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlInsElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlInsElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlInsElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlInsElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlInsElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlInsElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlInsElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlInsElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
