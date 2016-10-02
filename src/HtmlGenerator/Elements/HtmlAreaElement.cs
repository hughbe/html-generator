using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlAreaElement : HtmlElement
    {
        public HtmlAreaElement() : base("area", true) 
        {    
        }

        public new HtmlAreaElement WithElement(HtmlElement element) => (HtmlAreaElement)base.WithElement(element);
        public new HtmlAreaElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlAreaElement)base.WithElements(elements);

        public new HtmlAreaElement WithInnerText(string innerText) => (HtmlAreaElement)base.WithInnerText(innerText);

        public new HtmlAreaElement WithAttribute(HtmlAttribute attribute) => (HtmlAreaElement)base.WithAttribute(attribute);
        public new HtmlAreaElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlAreaElement)base.WithAttributes(attributes);

		public HtmlAreaElement WithAlt(string value) => WithAttribute(Attribute.Alt(value));

		public HtmlAreaElement WithCoords(string value) => WithAttribute(Attribute.Coords(value));

		public HtmlAreaElement WithDownload(string value) => WithAttribute(Attribute.Download(value));

		public HtmlAreaElement WithHref(string value) => WithAttribute(Attribute.Href(value));

		public HtmlAreaElement WithHrefLang(string value) => WithAttribute(Attribute.HrefLang(value));

		public HtmlAreaElement WithMedia(string value) => WithAttribute(Attribute.Media(value));

		public HtmlAreaElement WithRel(string value) => WithAttribute(Attribute.Rel(value));

		public HtmlAreaElement WithShape(string value) => WithAttribute(Attribute.Shape(value));

		public HtmlAreaElement WithTarget(string value) => WithAttribute(Attribute.Target(value));

		public HtmlAreaElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlAreaElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlAreaElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlAreaElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlAreaElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlAreaElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlAreaElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlAreaElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlAreaElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlAreaElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlAreaElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlAreaElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
