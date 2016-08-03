using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlPElement : HtmlElement 
    {
        public HtmlPElement() : base("p", false) 
        {    
        }

        public new HtmlPElement WithChild(HtmlElement child) => (HtmlPElement)base.WithChild(child);
        public new HtmlPElement WithChildren(Collection<HtmlElement> children) => (HtmlPElement)base.WithChildren(children);

        public new HtmlPElement WithInnerText(string innerText) => (HtmlPElement)base.WithInnerText(innerText);

        public new HtmlPElement WithAttribute(HtmlAttribute attribute) => (HtmlPElement)base.WithAttribute(attribute);
        public new HtmlPElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlPElement)base.WithAttributes(attributes);

		public HtmlPElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlPElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlPElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlPElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlPElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlPElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlPElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlPElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlPElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlPElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlPElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
