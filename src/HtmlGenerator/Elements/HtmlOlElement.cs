using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlOlElement : HtmlElement 
    {
        public HtmlOlElement() : base("ol", false) 
        {    
        }

        public new HtmlOlElement WithChild(HtmlElement child) => (HtmlOlElement)base.WithChild(child);
        public new HtmlOlElement WithChildren(Collection<HtmlElement> children) => (HtmlOlElement)base.WithChildren(children);

        public new HtmlOlElement WithInnerText(string innerText) => (HtmlOlElement)base.WithInnerText(innerText);

        public new HtmlOlElement WithAttribute(HtmlAttribute attribute) => (HtmlOlElement)base.WithAttribute(attribute);
        public new HtmlOlElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlOlElement)base.WithAttributes(attributes);

		public HtmlOlElement WithReversed(string value) => WithAttribute(Attribute.Reversed(value));

		public HtmlOlElement WithStart(string value) => WithAttribute(Attribute.Start(value));

		public HtmlOlElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlOlElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlOlElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlOlElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlOlElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlOlElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlOlElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlOlElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlOlElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlOlElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlOlElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlOlElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
