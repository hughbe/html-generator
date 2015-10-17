using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlRubyElement : HtmlElement 
    {
        public HtmlRubyElement() : base("ruby", false) 
        {    
        }

        public new HtmlRubyElement WithChild(HtmlElement child) => (HtmlRubyElement)base.WithChild(child);
        public new HtmlRubyElement WithChildren(Collection<HtmlElement> children) => (HtmlRubyElement)base.WithChildren(children);

        public new HtmlRubyElement WithInnerText(string innerText) => (HtmlRubyElement)base.WithInnerText(innerText);

        public new HtmlRubyElement WithAttribute(HtmlAttribute attribute) => (HtmlRubyElement)base.WithAttribute(attribute);
        public new HtmlRubyElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlRubyElement)base.WithAttributes(attributes);

		public HtmlRubyElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlRubyElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlRubyElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlRubyElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlRubyElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlRubyElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlRubyElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlRubyElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlRubyElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlRubyElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlRubyElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
