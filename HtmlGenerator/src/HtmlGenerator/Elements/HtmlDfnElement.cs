using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlDfnElement : HtmlElement 
    {
        public HtmlDfnElement() : base("dfn", false) 
        {    
        }

        public new HtmlDfnElement WithChild(HtmlElement child) => (HtmlDfnElement)base.WithChild(child);
        public new HtmlDfnElement WithChildren(Collection<HtmlElement> children) => (HtmlDfnElement)base.WithChildren(children);

        public new HtmlDfnElement WithInnerText(string innerText) => (HtmlDfnElement)base.WithInnerText(innerText);

        public new HtmlDfnElement WithAttribute(HtmlAttribute attribute) => (HtmlDfnElement)base.WithAttribute(attribute);
        public new HtmlDfnElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlDfnElement)base.WithAttributes(attributes);

		public HtmlDfnElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDfnElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDfnElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDfnElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDfnElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDfnElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDfnElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDfnElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDfnElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDfnElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDfnElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
