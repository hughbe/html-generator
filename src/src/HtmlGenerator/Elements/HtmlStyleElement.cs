using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlStyleElement : HtmlElement 
    {
        public HtmlStyleElement() : base("style", false) 
        {    
        }

        public new HtmlStyleElement WithChild(HtmlElement child) => (HtmlStyleElement)base.WithChild(child);
        public new HtmlStyleElement WithChildren(Collection<HtmlElement> children) => (HtmlStyleElement)base.WithChildren(children);

        public new HtmlStyleElement WithInnerText(string innerText) => (HtmlStyleElement)base.WithInnerText(innerText);

        public new HtmlStyleElement WithAttribute(HtmlAttribute attribute) => (HtmlStyleElement)base.WithAttribute(attribute);
        public new HtmlStyleElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlStyleElement)base.WithAttributes(attributes);

		public HtmlStyleElement WithDisabled() => WithAttribute(Attribute.Disabled);

		public HtmlStyleElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlStyleElement WithMedia(string value) => WithAttribute(Attribute.Media(value));

		public HtmlStyleElement WithScoped() => WithAttribute(Attribute.Scoped);

		public HtmlStyleElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlStyleElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlStyleElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlStyleElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlStyleElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlStyleElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlStyleElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlStyleElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlStyleElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlStyleElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlStyleElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
