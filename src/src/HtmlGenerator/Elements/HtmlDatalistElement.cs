using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlDatalistElement : HtmlElement 
    {
        public HtmlDatalistElement() : base("datalist", false) 
        {    
        }

        public new HtmlDatalistElement WithChild(HtmlElement child) => (HtmlDatalistElement)base.WithChild(child);
        public new HtmlDatalistElement WithChildren(Collection<HtmlElement> children) => (HtmlDatalistElement)base.WithChildren(children);

        public new HtmlDatalistElement WithInnerText(string innerText) => (HtmlDatalistElement)base.WithInnerText(innerText);

        public new HtmlDatalistElement WithAttribute(HtmlAttribute attribute) => (HtmlDatalistElement)base.WithAttribute(attribute);
        public new HtmlDatalistElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlDatalistElement)base.WithAttributes(attributes);

		public HtmlDatalistElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlDatalistElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlDatalistElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlDatalistElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlDatalistElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlDatalistElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlDatalistElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlDatalistElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlDatalistElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlDatalistElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlDatalistElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
