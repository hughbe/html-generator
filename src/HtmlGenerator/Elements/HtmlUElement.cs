using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlUElement : HtmlElement 
    {
        public HtmlUElement() : base("u", false) 
        {    
        }

        public new HtmlUElement WithChild(HtmlElement child) => (HtmlUElement)base.WithChild(child);
        public new HtmlUElement WithChildren(Collection<HtmlElement> children) => (HtmlUElement)base.WithChildren(children);

        public new HtmlUElement WithInnerText(string innerText) => (HtmlUElement)base.WithInnerText(innerText);

        public new HtmlUElement WithAttribute(HtmlAttribute attribute) => (HtmlUElement)base.WithAttribute(attribute);
        public new HtmlUElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlUElement)base.WithAttributes(attributes);

		public HtmlUElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlUElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlUElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlUElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlUElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlUElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlUElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlUElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlUElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlUElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlUElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
