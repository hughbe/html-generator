using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlSupElement : HtmlElement 
    {
        public HtmlSupElement() : base("sup", false) 
        {    
        }

        public new HtmlSupElement WithChild(HtmlElement child) => (HtmlSupElement)base.WithChild(child);
        public new HtmlSupElement WithChildren(Collection<HtmlElement> children) => (HtmlSupElement)base.WithChildren(children);

        public new HtmlSupElement WithInnerText(string innerText) => (HtmlSupElement)base.WithInnerText(innerText);

        public new HtmlSupElement WithAttribute(HtmlAttribute attribute) => (HtmlSupElement)base.WithAttribute(attribute);
        public new HtmlSupElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlSupElement)base.WithAttributes(attributes);

		public HtmlSupElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlSupElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlSupElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlSupElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlSupElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlSupElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlSupElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlSupElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlSupElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlSupElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlSupElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
