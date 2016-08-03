using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlSampElement : HtmlElement 
    {
        public HtmlSampElement() : base("samp", false) 
        {    
        }

        public new HtmlSampElement WithChild(HtmlElement child) => (HtmlSampElement)base.WithChild(child);
        public new HtmlSampElement WithChildren(Collection<HtmlElement> children) => (HtmlSampElement)base.WithChildren(children);

        public new HtmlSampElement WithInnerText(string innerText) => (HtmlSampElement)base.WithInnerText(innerText);

        public new HtmlSampElement WithAttribute(HtmlAttribute attribute) => (HtmlSampElement)base.WithAttribute(attribute);
        public new HtmlSampElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlSampElement)base.WithAttributes(attributes);

		public HtmlSampElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlSampElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlSampElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlSampElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlSampElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlSampElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlSampElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlSampElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlSampElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlSampElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlSampElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
