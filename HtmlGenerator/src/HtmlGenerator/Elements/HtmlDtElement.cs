using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlDtElement : HtmlElement 
    {
        public HtmlDtElement() : base("dt", false) 
        {    
        }

        public new HtmlDtElement WithChild(HtmlElement child) => (HtmlDtElement)base.WithChild(child);
        public new HtmlDtElement WithChildren(Collection<HtmlElement> children) => (HtmlDtElement)base.WithChildren(children);

        public new HtmlDtElement WithInnerText(string innerText) => (HtmlDtElement)base.WithInnerText(innerText);

        public new HtmlDtElement WithAttribute(HtmlAttribute attribute) => (HtmlDtElement)base.WithAttribute(attribute);
        public new HtmlDtElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlDtElement)base.WithAttributes(attributes);

		public HtmlDtElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDtElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDtElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDtElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDtElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDtElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDtElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDtElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDtElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDtElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDtElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
