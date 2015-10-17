using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlDivElement : HtmlElement 
    {
        public HtmlDivElement() : base("div", false) 
        {    
        }

        public new HtmlDivElement WithChild(HtmlElement child) => (HtmlDivElement)base.WithChild(child);
        public new HtmlDivElement WithChildren(Collection<HtmlElement> children) => (HtmlDivElement)base.WithChildren(children);

        public new HtmlDivElement WithInnerText(string innerText) => (HtmlDivElement)base.WithInnerText(innerText);

        public new HtmlDivElement WithAttribute(HtmlAttribute attribute) => (HtmlDivElement)base.WithAttribute(attribute);
        public new HtmlDivElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlDivElement)base.WithAttributes(attributes);

		public HtmlDivElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDivElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDivElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDivElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDivElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDivElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDivElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDivElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDivElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDivElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDivElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
