using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlTrackElement : HtmlElement
    {
        public HtmlTrackElement() : base("track", true) 
        {    
        }

        public new HtmlTrackElement WithElement(HtmlElement element) => (HtmlTrackElement)base.WithElement(element);
        public new HtmlTrackElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlTrackElement)base.WithElements(elements);

        public new HtmlTrackElement WithInnerText(string innerText) => (HtmlTrackElement)base.WithInnerText(innerText);

        public new HtmlTrackElement WithAttribute(HtmlAttribute attribute) => (HtmlTrackElement)base.WithAttribute(attribute);
        public new HtmlTrackElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlTrackElement)base.WithAttributes(attributes);

		public HtmlTrackElement WithDefault() => WithAttribute(Attribute.Default);

		public HtmlTrackElement WithKind(string value) => WithAttribute(Attribute.Kind(value));

		public HtmlTrackElement WithLabel(string value) => WithAttribute(Attribute.Label(value));

		public HtmlTrackElement WithSrc(string value) => WithAttribute(Attribute.Src(value));

		public HtmlTrackElement WithSrcLang(string value) => WithAttribute(Attribute.SrcLang(value));

		public HtmlTrackElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlTrackElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlTrackElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlTrackElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlTrackElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlTrackElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlTrackElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlTrackElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlTrackElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlTrackElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlTrackElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
