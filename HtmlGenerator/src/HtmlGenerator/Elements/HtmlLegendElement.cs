using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlLegendElement : HtmlElement 
    {
        public HtmlLegendElement() : base("legend", false) 
        {    
        }

        public new HtmlLegendElement WithChild(HtmlElement child) => (HtmlLegendElement)base.WithChild(child);
        public new HtmlLegendElement WithChildren(Collection<HtmlElement> children) => (HtmlLegendElement)base.WithChildren(children);

        public new HtmlLegendElement WithInnerText(string innerText) => (HtmlLegendElement)base.WithInnerText(innerText);

        public new HtmlLegendElement WithAttribute(HtmlAttribute attribute) => (HtmlLegendElement)base.WithAttribute(attribute);
        public new HtmlLegendElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlLegendElement)base.WithAttributes(attributes);

		public HtmlLegendElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlLegendElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlLegendElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlLegendElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlLegendElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlLegendElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlLegendElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlLegendElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlLegendElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlLegendElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlLegendElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
