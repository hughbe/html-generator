using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlLinkElement : HtmlElement 
    {
        public HtmlLinkElement() : base("link", true) 
        {    
        }

        public new HtmlLinkElement WithChild(HtmlElement child) => (HtmlLinkElement)base.WithChild(child);
        public new HtmlLinkElement WithChildren(Collection<HtmlElement> children) => (HtmlLinkElement)base.WithChildren(children);

        public new HtmlLinkElement WithInnerText(string innerText) => (HtmlLinkElement)base.WithInnerText(innerText);

        public new HtmlLinkElement WithAttribute(HtmlAttribute attribute) => (HtmlLinkElement)base.WithAttribute(attribute);
        public new HtmlLinkElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlLinkElement)base.WithAttributes(attributes);

		public HtmlLinkElement WithCrossOrigin(string value) => WithAttribute(Attribute.CrossOrigin(value));

		public HtmlLinkElement WithHref(string value) => WithAttribute(Attribute.Href(value));

		public HtmlLinkElement WithHrefLang(string value) => WithAttribute(Attribute.HrefLang(value));

		public HtmlLinkElement WithIntegrity(string value) => WithAttribute(Attribute.Integrity(value));

		public HtmlLinkElement WithMedia(string value) => WithAttribute(Attribute.Media(value));

		public HtmlLinkElement WithRel(string value) => WithAttribute(Attribute.Rel(value));

		public HtmlLinkElement WithSizes(string value) => WithAttribute(Attribute.Sizes(value));

		public HtmlLinkElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlLinkElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlLinkElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlLinkElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlLinkElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlLinkElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlLinkElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlLinkElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlLinkElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlLinkElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlLinkElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlLinkElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
