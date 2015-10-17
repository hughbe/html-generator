using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlSourceElement : HtmlElement 
    {
        public HtmlSourceElement() : base("source", true) 
        {    
        }

        public new HtmlSourceElement WithChild(HtmlElement child) => (HtmlSourceElement)base.WithChild(child);
        public new HtmlSourceElement WithChildren(Collection<HtmlElement> children) => (HtmlSourceElement)base.WithChildren(children);

        public new HtmlSourceElement WithInnerText(string innerText) => (HtmlSourceElement)base.WithInnerText(innerText);

        public new HtmlSourceElement WithAttribute(HtmlAttribute attribute) => (HtmlSourceElement)base.WithAttribute(attribute);
        public new HtmlSourceElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlSourceElement)base.WithAttributes(attributes);

		public HtmlSourceElement WithSrc(string value) => WithAttribute(Attribute.Src(value));

		public HtmlSourceElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlSourceElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlSourceElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlSourceElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlSourceElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlSourceElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlSourceElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlSourceElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlSourceElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlSourceElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlSourceElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlSourceElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
