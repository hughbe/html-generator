using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlIElement : HtmlElement 
    {
        public HtmlIElement() : base("i", false) 
        {    
        }

        public new HtmlIElement WithChild(HtmlElement child) => (HtmlIElement)base.WithChild(child);
        public new HtmlIElement WithChildren(Collection<HtmlElement> children) => (HtmlIElement)base.WithChildren(children);

        public new HtmlIElement WithInnerText(string innerText) => (HtmlIElement)base.WithInnerText(innerText);

        public new HtmlIElement WithAttribute(HtmlAttribute attribute) => (HtmlIElement)base.WithAttribute(attribute);
        public new HtmlIElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlIElement)base.WithAttributes(attributes);

		public HtmlIElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlIElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlIElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlIElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlIElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlIElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlIElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlIElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlIElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlIElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlIElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
