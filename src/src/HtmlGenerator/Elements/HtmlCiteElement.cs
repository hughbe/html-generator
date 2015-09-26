using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlCiteElement : HtmlElement 
    {
        public HtmlCiteElement() : base("cite", false) 
        {    
        }

        public new HtmlCiteElement WithChild(HtmlElement child) => (HtmlCiteElement)base.WithChild(child);
        public new HtmlCiteElement WithChildren(Collection<HtmlElement> children) => (HtmlCiteElement)base.WithChildren(children);

        public new HtmlCiteElement WithInnerText(string innerText) => (HtmlCiteElement)base.WithInnerText(innerText);

        public new HtmlCiteElement WithAttribute(HtmlAttribute attribute) => (HtmlCiteElement)base.WithAttribute(attribute);
        public new HtmlCiteElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlCiteElement)base.WithAttributes(attributes);

		public HtmlCiteElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlCiteElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlCiteElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlCiteElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlCiteElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlCiteElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlCiteElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlCiteElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlCiteElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlCiteElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlCiteElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
