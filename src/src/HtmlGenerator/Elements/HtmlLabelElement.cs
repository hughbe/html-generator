using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlLabelElement : HtmlElement 
    {
        public HtmlLabelElement() : base("label", false) 
        {    
        }

        public new HtmlLabelElement WithChild(HtmlElement child) => (HtmlLabelElement)base.WithChild(child);
        public new HtmlLabelElement WithChildren(Collection<HtmlElement> children) => (HtmlLabelElement)base.WithChildren(children);

        public new HtmlLabelElement WithInnerText(string innerText) => (HtmlLabelElement)base.WithInnerText(innerText);

        public new HtmlLabelElement WithAttribute(HtmlAttribute attribute) => (HtmlLabelElement)base.WithAttribute(attribute);
        public new HtmlLabelElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlLabelElement)base.WithAttributes(attributes);

		public HtmlLabelElement WithFor(string value) => WithAttribute(Attribute.For(value));

		public HtmlLabelElement WithForm(string value) => WithAttribute(Attribute.Form(value));

		public HtmlLabelElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlLabelElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlLabelElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlLabelElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlLabelElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlLabelElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlLabelElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlLabelElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlLabelElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlLabelElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlLabelElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
