using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlParamElement : HtmlElement 
    {
        public HtmlParamElement() : base("param", true) 
        {    
        }

        public new HtmlParamElement WithChild(HtmlElement child) => (HtmlParamElement)base.WithChild(child);
        public new HtmlParamElement WithChildren(Collection<HtmlElement> children) => (HtmlParamElement)base.WithChildren(children);

        public new HtmlParamElement WithInnerText(string innerText) => (HtmlParamElement)base.WithInnerText(innerText);

        public new HtmlParamElement WithAttribute(HtmlAttribute attribute) => (HtmlParamElement)base.WithAttribute(attribute);
        public new HtmlParamElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlParamElement)base.WithAttributes(attributes);

		public HtmlParamElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlParamElement WithValue(string value) => WithAttribute(Attribute.Value(value));

		public HtmlParamElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlParamElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlParamElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlParamElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlParamElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlParamElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlParamElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlParamElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlParamElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlParamElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlParamElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
