using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlFormElement : HtmlElement 
    {
        public HtmlFormElement() : base("form", false) 
        {    
        }

        public new HtmlFormElement WithChild(HtmlElement child) => (HtmlFormElement)base.WithChild(child);
        public new HtmlFormElement WithChildren(Collection<HtmlElement> children) => (HtmlFormElement)base.WithChildren(children);

        public new HtmlFormElement WithInnerText(string innerText) => (HtmlFormElement)base.WithInnerText(innerText);

        public new HtmlFormElement WithAttribute(HtmlAttribute attribute) => (HtmlFormElement)base.WithAttribute(attribute);
        public new HtmlFormElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlFormElement)base.WithAttributes(attributes);

		public HtmlFormElement WithAcceptCharset(string value) => WithAttribute(Attribute.AcceptCharset(value));

		public HtmlFormElement WithAction(string value) => WithAttribute(Attribute.Action(value));

		public HtmlFormElement WithAutoComplete(string value) => WithAttribute(Attribute.AutoComplete(value));

		public HtmlFormElement WithEncType(string value) => WithAttribute(Attribute.EncType(value));

		public HtmlFormElement WithMethod(string value) => WithAttribute(Attribute.Method(value));

		public HtmlFormElement WithName(string value) => WithAttribute(Attribute.Name(value));

		public HtmlFormElement WithNoValidate() => WithAttribute(Attribute.NoValidate);

		public HtmlFormElement WithTarget(string value) => WithAttribute(Attribute.Target(value));

		public HtmlFormElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlFormElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlFormElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlFormElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlFormElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlFormElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlFormElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlFormElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlFormElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlFormElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlFormElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
