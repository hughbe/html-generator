using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlHeadElement : HtmlElement 
    {
        public HtmlHeadElement() : base("head", false) 
        {    
        }

        public new HtmlHeadElement WithChild(HtmlElement child) => (HtmlHeadElement)base.WithChild(child);
        public new HtmlHeadElement WithChildren(Collection<HtmlElement> children) => (HtmlHeadElement)base.WithChildren(children);

        public new HtmlHeadElement WithInnerText(string innerText) => (HtmlHeadElement)base.WithInnerText(innerText);

        public new HtmlHeadElement WithAttribute(HtmlAttribute attribute) => (HtmlHeadElement)base.WithAttribute(attribute);
        public new HtmlHeadElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlHeadElement)base.WithAttributes(attributes);

		public HtmlHeadElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlHeadElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlHeadElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlHeadElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlHeadElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlHeadElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlHeadElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlHeadElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlHeadElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlHeadElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlHeadElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
