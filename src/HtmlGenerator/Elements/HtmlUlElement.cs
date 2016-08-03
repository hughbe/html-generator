using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlUlElement : HtmlElement 
    {
        public HtmlUlElement() : base("ul", false) 
        {    
        }

        public new HtmlUlElement WithChild(HtmlElement child) => (HtmlUlElement)base.WithChild(child);
        public new HtmlUlElement WithChildren(Collection<HtmlElement> children) => (HtmlUlElement)base.WithChildren(children);

        public new HtmlUlElement WithInnerText(string innerText) => (HtmlUlElement)base.WithInnerText(innerText);

        public new HtmlUlElement WithAttribute(HtmlAttribute attribute) => (HtmlUlElement)base.WithAttribute(attribute);
        public new HtmlUlElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlUlElement)base.WithAttributes(attributes);

		public HtmlUlElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlUlElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlUlElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlUlElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlUlElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlUlElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlUlElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlUlElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlUlElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlUlElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlUlElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
