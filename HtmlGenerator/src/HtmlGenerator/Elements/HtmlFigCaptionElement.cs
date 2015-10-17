using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlFigCaptionElement : HtmlElement 
    {
        public HtmlFigCaptionElement() : base("figcaption", false) 
        {    
        }

        public new HtmlFigCaptionElement WithChild(HtmlElement child) => (HtmlFigCaptionElement)base.WithChild(child);
        public new HtmlFigCaptionElement WithChildren(Collection<HtmlElement> children) => (HtmlFigCaptionElement)base.WithChildren(children);

        public new HtmlFigCaptionElement WithInnerText(string innerText) => (HtmlFigCaptionElement)base.WithInnerText(innerText);

        public new HtmlFigCaptionElement WithAttribute(HtmlAttribute attribute) => (HtmlFigCaptionElement)base.WithAttribute(attribute);
        public new HtmlFigCaptionElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlFigCaptionElement)base.WithAttributes(attributes);

		public HtmlFigCaptionElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlFigCaptionElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlFigCaptionElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlFigCaptionElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlFigCaptionElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlFigCaptionElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlFigCaptionElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlFigCaptionElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlFigCaptionElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlFigCaptionElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlFigCaptionElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
