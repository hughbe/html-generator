using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlDialogElement : HtmlElement
    {
        public HtmlDialogElement() : base("dialog", false) 
        {    
        }

        public new HtmlDialogElement WithElement(HtmlElement element) => (HtmlDialogElement)base.WithElement(element);
        public new HtmlDialogElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlDialogElement)base.WithElements(elements);

        public new HtmlDialogElement WithInnerText(string innerText) => (HtmlDialogElement)base.WithInnerText(innerText);

        public new HtmlDialogElement WithAttribute(HtmlAttribute attribute) => (HtmlDialogElement)base.WithAttribute(attribute);
        public new HtmlDialogElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlDialogElement)base.WithAttributes(attributes);

		public HtmlDialogElement WithOpen(string value) => WithAttribute(Attribute.Open(value));

		public HtmlDialogElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDialogElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDialogElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDialogElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDialogElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDialogElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDialogElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDialogElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDialogElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDialogElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDialogElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
