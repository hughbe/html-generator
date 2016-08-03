using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlProgressElement : HtmlElement 
    {
        public HtmlProgressElement() : base("progress", false) 
        {    
        }

        public new HtmlProgressElement WithChild(HtmlElement child) => (HtmlProgressElement)base.WithChild(child);
        public new HtmlProgressElement WithChildren(Collection<HtmlElement> children) => (HtmlProgressElement)base.WithChildren(children);

        public new HtmlProgressElement WithInnerText(string innerText) => (HtmlProgressElement)base.WithInnerText(innerText);

        public new HtmlProgressElement WithAttribute(HtmlAttribute attribute) => (HtmlProgressElement)base.WithAttribute(attribute);
        public new HtmlProgressElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlProgressElement)base.WithAttributes(attributes);

		public HtmlProgressElement WithMax(string value) => WithAttribute(Attribute.Max(value));

		public HtmlProgressElement WithValue(string value) => WithAttribute(Attribute.Value(value));

		public HtmlProgressElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlProgressElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlProgressElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlProgressElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlProgressElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlProgressElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlProgressElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlProgressElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlProgressElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlProgressElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlProgressElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
