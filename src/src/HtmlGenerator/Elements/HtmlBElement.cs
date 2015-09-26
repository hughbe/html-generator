using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlBElement : HtmlElement 
    {
        public HtmlBElement() : base("b", false) 
        {    
        }

        public new HtmlBElement WithChild(HtmlElement child) => (HtmlBElement)base.WithChild(child);
        public new HtmlBElement WithChildren(Collection<HtmlElement> children) => (HtmlBElement)base.WithChildren(children);

        public new HtmlBElement WithInnerText(string innerText) => (HtmlBElement)base.WithInnerText(innerText);

        public new HtmlBElement WithAttribute(HtmlAttribute attribute) => (HtmlBElement)base.WithAttribute(attribute);
        public new HtmlBElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlBElement)base.WithAttributes(attributes);

		public HtmlBElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlBElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlBElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlBElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlBElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlBElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlBElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlBElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlBElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlBElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlBElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
