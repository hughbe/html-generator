namespace HtmlGenerator
{
    public class HtmlFormElement : HtmlElement 
    {
        internal HtmlFormElement() : base("form", false) 
        {    
        }

		public HtmlFormElement WithAcceptCharsetAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.AcceptCharset(value));

		public HtmlFormElement WithActionAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.Action(value));

		public HtmlFormElement WithAutoCompleteAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.AutoComplete(value));

		public HtmlFormElement WithEncTypeAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.EncType(value));

		public HtmlFormElement WithMethodAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.Method(value));

		public HtmlFormElement WithNameAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.Name(value));

		public HtmlFormElement WithNoValidateAttribute() => (HtmlFormElement)WithAttribute(Attribute.NoValidate);

		public HtmlFormElement WithTargetAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.Target(value));

		public HtmlFormElement WithAccessKey(string value) => (HtmlFormElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlFormElement WithClass(string value) => (HtmlFormElement)WithAttribute(Attribute.Class(value));

		public HtmlFormElement WithContentEditable(string value) => (HtmlFormElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlFormElement WithContextMenuAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlFormElement WithDir(string value) => (HtmlFormElement)WithAttribute(Attribute.Dir(value));

		public HtmlFormElement WithHidden(string value) => (HtmlFormElement)WithAttribute(Attribute.Hidden(value));

		public HtmlFormElement WithId(string value) => (HtmlFormElement)WithAttribute(Attribute.Id(value));

		public HtmlFormElement WithLang(string value) => (HtmlFormElement)WithAttribute(Attribute.Lang(value));

		public HtmlFormElement WithSpellCheck(string value) => (HtmlFormElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlFormElement WithStyleAttribute(string value) => (HtmlFormElement)WithAttribute(Attribute.Style(value));

		public HtmlFormElement WithTabIndex(string value) => (HtmlFormElement)WithAttribute(Attribute.TabIndex(value));
    }
}
