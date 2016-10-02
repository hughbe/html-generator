using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlCanvasElement : HtmlElement
    {
        public HtmlCanvasElement() : base("canvas", false) 
        {    
        }

        public new HtmlCanvasElement WithElement(HtmlElement element) => (HtmlCanvasElement)base.WithElement(element);
        public new HtmlCanvasElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlCanvasElement)base.WithElements(elements);

        public new HtmlCanvasElement WithInnerText(string innerText) => (HtmlCanvasElement)base.WithInnerText(innerText);

        public new HtmlCanvasElement WithAttribute(HtmlAttribute attribute) => (HtmlCanvasElement)base.WithAttribute(attribute);
        public new HtmlCanvasElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlCanvasElement)base.WithAttributes(attributes);

		public HtmlCanvasElement WithHeight(string value) => WithAttribute(Attribute.Height(value));

		public HtmlCanvasElement WithWidth(string value) => WithAttribute(Attribute.Width(value));

		public HtmlCanvasElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlCanvasElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlCanvasElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlCanvasElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlCanvasElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlCanvasElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlCanvasElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlCanvasElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlCanvasElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlCanvasElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlCanvasElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
