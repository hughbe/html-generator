using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlBrElement : HtmlElement 
    {
        public HtmlBrElement() : base("br", true) 
        {    
        }

        public new HtmlBrElement WithChild(HtmlElement child) => (HtmlBrElement)base.WithChild(child);
        public new HtmlBrElement WithChildren(Collection<HtmlElement> children) => (HtmlBrElement)base.WithChildren(children);

        public new HtmlBrElement WithInnerText(string innerText) => (HtmlBrElement)base.WithInnerText(innerText);

        public new HtmlBrElement WithAttribute(HtmlAttribute attribute) => (HtmlBrElement)base.WithAttribute(attribute);
        public new HtmlBrElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlBrElement)base.WithAttributes(attributes);

		public HtmlBrElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlBrElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlBrElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlBrElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlBrElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlBrElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlBrElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlBrElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlBrElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlBrElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlBrElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
