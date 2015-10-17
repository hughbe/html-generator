namespace HtmlGenerator
{
    public class HtmlFormElement : HtmlElement 
    {
        public HtmlFormElement() : base("form", false) 
        {    
        }

		public HtmlFormElement WithAcceptCharset(string value) => (HtmlFormElement)WithAttribute(Attribute.AcceptCharset(value));

		public HtmlFormElement WithAction(string value) => (HtmlFormElement)WithAttribute(Attribute.Action(value));

		public HtmlFormElement WithAutoComplete(string value) => (HtmlFormElement)WithAttribute(Attribute.AutoComplete(value));

		public HtmlFormElement WithEncType(string value) => (HtmlFormElement)WithAttribute(Attribute.EncType(value));

		public HtmlFormElement WithMethod(string value) => (HtmlFormElement)WithAttribute(Attribute.Method(value));

		public HtmlFormElement WithName(string value) => (HtmlFormElement)WithAttribute(Attribute.Name(value));

		public HtmlFormElement WithNoValidate() => (HtmlFormElement)WithAttribute(Attribute.NoValidate);

		public HtmlFormElement WithTarget(string value) => (HtmlFormElement)WithAttribute(Attribute.Target(value));

		public HtmlFormElement WithAccessKey(string value) => (HtmlFormElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlFormElement WithClass(string value) => (HtmlFormElement)WithAttribute(Attribute.Class(value));

		public HtmlFormElement WithContentEditable(string value) => (HtmlFormElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlFormElement WithContextMenu(string value) => (HtmlFormElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlFormElement WithDir(string value) => (HtmlFormElement)WithAttribute(Attribute.Dir(value));

		public HtmlFormElement WithHidden(string value) => (HtmlFormElement)WithAttribute(Attribute.Hidden(value));

		public HtmlFormElement WithId(string value) => (HtmlFormElement)WithAttribute(Attribute.Id(value));

		public HtmlFormElement WithLang(string value) => (HtmlFormElement)WithAttribute(Attribute.Lang(value));

		public HtmlFormElement WithSpellCheck(string value) => (HtmlFormElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlFormElement WithStyle(string value) => (HtmlFormElement)WithAttribute(Attribute.Style(value));

		public HtmlFormElement WithTabIndex(string value) => (HtmlFormElement)WithAttribute(Attribute.TabIndex(value));
    }
}
