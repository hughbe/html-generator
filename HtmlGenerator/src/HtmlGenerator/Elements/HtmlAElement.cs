using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlAElement : HtmlElement 
    {
        public HtmlAElement() : base("a", false) 
        {    
        }

        public new HtmlAElement WithChild(HtmlElement child) => (HtmlAElement)base.WithChild(child);
        public new HtmlAElement WithChildren(Collection<HtmlElement> children) => (HtmlAElement)base.WithChildren(children);

        public new HtmlAElement WithInnerText(string innerText) => (HtmlAElement)base.WithInnerText(innerText);

        public new HtmlAElement WithAttribute(HtmlAttribute attribute) => (HtmlAElement)base.WithAttribute(attribute);
        public new HtmlAElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlAElement)base.WithAttributes(attributes);

		public HtmlAElement WithDownload(string value) => WithAttribute(Attribute.Download(value));

		public HtmlAElement WithHref(string value) => WithAttribute(Attribute.Href(value));

		public HtmlAElement WithHrefLang(string value) => WithAttribute(Attribute.HrefLang(value));

		public HtmlAElement WithMedia(string value) => WithAttribute(Attribute.Media(value));

		public HtmlAElement WithPing(string value) => WithAttribute(Attribute.Ping(value));

		public HtmlAElement WithRel(string value) => WithAttribute(Attribute.Rel(value));

		public HtmlAElement WithTarget(string value) => WithAttribute(Attribute.Target(value));

		public HtmlAElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlAElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlAElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlAElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlAElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlAElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlAElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlAElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlAElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlAElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlAElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlAElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
