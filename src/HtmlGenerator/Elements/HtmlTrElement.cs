using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlTrElement : HtmlElement 
    {
        public HtmlTrElement() : base("tr", false) 
        {    
        }

        public new HtmlTrElement WithChild(HtmlElement child) => (HtmlTrElement)base.WithChild(child);
        public new HtmlTrElement WithChildren(Collection<HtmlElement> children) => (HtmlTrElement)base.WithChildren(children);

        public new HtmlTrElement WithInnerText(string innerText) => (HtmlTrElement)base.WithInnerText(innerText);

        public new HtmlTrElement WithAttribute(HtmlAttribute attribute) => (HtmlTrElement)base.WithAttribute(attribute);
        public new HtmlTrElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlTrElement)base.WithAttributes(attributes);

		public HtmlTrElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlTrElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlTrElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlTrElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlTrElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlTrElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlTrElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlTrElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlTrElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlTrElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlTrElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
