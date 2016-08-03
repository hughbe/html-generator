using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlWbrElement : HtmlElement 
    {
        public HtmlWbrElement() : base("wbr", false) 
        {    
        }

        public new HtmlWbrElement WithChild(HtmlElement child) => (HtmlWbrElement)base.WithChild(child);
        public new HtmlWbrElement WithChildren(Collection<HtmlElement> children) => (HtmlWbrElement)base.WithChildren(children);

        public new HtmlWbrElement WithInnerText(string innerText) => (HtmlWbrElement)base.WithInnerText(innerText);

        public new HtmlWbrElement WithAttribute(HtmlAttribute attribute) => (HtmlWbrElement)base.WithAttribute(attribute);
        public new HtmlWbrElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlWbrElement)base.WithAttributes(attributes);

		public HtmlWbrElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlWbrElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlWbrElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlWbrElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlWbrElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlWbrElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlWbrElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlWbrElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlWbrElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlWbrElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlWbrElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
