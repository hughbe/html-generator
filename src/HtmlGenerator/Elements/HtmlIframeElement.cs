using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlIframeElement : HtmlElement
    {
        public HtmlIframeElement() : base("iframe", false) 
        {    
        }

        public new HtmlIframeElement WithElement(HtmlElement element) => (HtmlIframeElement)base.WithElement(element);
        public new HtmlIframeElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlIframeElement)base.WithElements(elements);

        public new HtmlIframeElement WithInnerText(string innerText) => (HtmlIframeElement)base.WithInnerText(innerText);

        public new HtmlIframeElement WithAttribute(HtmlAttribute attribute) => (HtmlIframeElement)base.WithAttribute(attribute);
        public new HtmlIframeElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlIframeElement)base.WithAttributes(attributes);

		public HtmlIframeElement WithAllowFullScreen() => WithAttribute(Attribute.AllowFullScreen);

		public HtmlIframeElement WithHeight(string value) => WithAttribute(Attribute.Height(value));

		public HtmlIframeElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlIframeElement WithSandbox() => WithAttribute(Attribute.Sandbox);

		public HtmlIframeElement WithSeamless() => WithAttribute(Attribute.Seamless);

		public HtmlIframeElement WithSrc(string value) => WithAttribute(Attribute.Src(value));

		public HtmlIframeElement WithSrcDoc(string value) => WithAttribute(Attribute.SrcDoc(value));

		public HtmlIframeElement WithWidth(string value) => WithAttribute(Attribute.Width(value));

		public HtmlIframeElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlIframeElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlIframeElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlIframeElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlIframeElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlIframeElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlIframeElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlIframeElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlIframeElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlIframeElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlIframeElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
