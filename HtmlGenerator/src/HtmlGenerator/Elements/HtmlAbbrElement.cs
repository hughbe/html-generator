using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlAbbrElement : HtmlElement 
    {
        public HtmlAbbrElement() : base("abbr", false) 
        {    
        }

        public new HtmlAbbrElement WithChild(HtmlElement child) => (HtmlAbbrElement)base.WithChild(child);
        public new HtmlAbbrElement WithChildren(Collection<HtmlElement> children) => (HtmlAbbrElement)base.WithChildren(children);

        public new HtmlAbbrElement WithInnerText(string innerText) => (HtmlAbbrElement)base.WithInnerText(innerText);

        public new HtmlAbbrElement WithAttribute(HtmlAttribute attribute) => (HtmlAbbrElement)base.WithAttribute(attribute);
        public new HtmlAbbrElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlAbbrElement)base.WithAttributes(attributes);

		public HtmlAbbrElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlAbbrElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlAbbrElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlAbbrElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlAbbrElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlAbbrElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlAbbrElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlAbbrElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlAbbrElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlAbbrElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlAbbrElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
