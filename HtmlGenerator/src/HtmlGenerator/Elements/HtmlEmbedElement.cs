using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlEmbedElement : HtmlElement 
    {
        public HtmlEmbedElement() : base("embed", true) 
        {    
        }

        public new HtmlEmbedElement WithChild(HtmlElement child) => (HtmlEmbedElement)base.WithChild(child);
        public new HtmlEmbedElement WithChildren(Collection<HtmlElement> children) => (HtmlEmbedElement)base.WithChildren(children);

        public new HtmlEmbedElement WithInnerText(string innerText) => (HtmlEmbedElement)base.WithInnerText(innerText);

        public new HtmlEmbedElement WithAttribute(HtmlAttribute attribute) => (HtmlEmbedElement)base.WithAttribute(attribute);
        public new HtmlEmbedElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlEmbedElement)base.WithAttributes(attributes);

		public HtmlEmbedElement WithHeight(string value) => WithAttribute(Attribute.Height(value));

		public HtmlEmbedElement WithSrc(string value) => WithAttribute(Attribute.Src(value));

		public HtmlEmbedElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlEmbedElement WithWidth(string value) => WithAttribute(Attribute.Width(value));

		public HtmlEmbedElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlEmbedElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlEmbedElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlEmbedElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlEmbedElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlEmbedElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlEmbedElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlEmbedElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlEmbedElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlEmbedElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlEmbedElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
