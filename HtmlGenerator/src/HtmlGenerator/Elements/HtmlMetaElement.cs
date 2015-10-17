using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlMetaElement : HtmlElement 
    {
        public HtmlMetaElement() : base("meta", true) 
        {    
        }

        public new HtmlMetaElement WithChild(HtmlElement child) => (HtmlMetaElement)base.WithChild(child);
        public new HtmlMetaElement WithChildren(Collection<HtmlElement> children) => (HtmlMetaElement)base.WithChildren(children);

        public new HtmlMetaElement WithInnerText(string innerText) => (HtmlMetaElement)base.WithInnerText(innerText);

        public new HtmlMetaElement WithAttribute(HtmlAttribute attribute) => (HtmlMetaElement)base.WithAttribute(attribute);
        public new HtmlMetaElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlMetaElement)base.WithAttributes(attributes);

		public HtmlMetaElement WithCharset(string value) => WithAttribute(Attribute.Charset(value));

		public HtmlMetaElement WithContent(string value) => WithAttribute(Attribute.Content(value));

		public HtmlMetaElement WithHttpEquiv(string value) => WithAttribute(Attribute.HttpEquiv(value));

		public HtmlMetaElement WithDefaultStyle(string value) => WithAttribute(Attribute.DefaultStyle(value));

		public HtmlMetaElement WithRefresh(string value) => WithAttribute(Attribute.Refresh(value));

		public HtmlMetaElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlMetaElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlMetaElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlMetaElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlMetaElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlMetaElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlMetaElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlMetaElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlMetaElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlMetaElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlMetaElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlMetaElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
