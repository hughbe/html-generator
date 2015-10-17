namespace HtmlGenerator
{
    public class HtmlButtonElement : HtmlElement 
    {
        public HtmlButtonElement() : base("button", false) 
        {    
        }

		public HtmlButtonElement WithAutoFocus() => (HtmlButtonElement)WithAttribute(Attribute.AutoFocus);

		public HtmlButtonElement WithDisabled() => (HtmlButtonElement)WithAttribute(Attribute.Disabled);

		public HtmlButtonElement WithForm(string value) => (HtmlButtonElement)WithAttribute(Attribute.Form(value));

		public HtmlButtonElement WithFormAction(string value) => (HtmlButtonElement)WithAttribute(Attribute.FormAction(value));

		public HtmlButtonElement WithFormEncType(string value) => (HtmlButtonElement)WithAttribute(Attribute.FormEncType(value));

		public HtmlButtonElement WithFormMethod(string value) => (HtmlButtonElement)WithAttribute(Attribute.FormMethod(value));

		public HtmlButtonElement WithFormNoValidate() => (HtmlButtonElement)WithAttribute(Attribute.FormNoValidate);

		public HtmlButtonElement WithFormTarget(string value) => (HtmlButtonElement)WithAttribute(Attribute.FormTarget(value));

		public HtmlButtonElement WithName(string value) => (HtmlButtonElement)WithAttribute(Attribute.Name(value));

		public HtmlButtonElement WithType(string value) => (HtmlButtonElement)WithAttribute(Attribute.Type(value));

		public HtmlButtonElement WithValue(string value) => (HtmlButtonElement)WithAttribute(Attribute.Value(value));

		public HtmlButtonElement WithAccessKey(string value) => (HtmlButtonElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlButtonElement WithClass(string value) => (HtmlButtonElement)WithAttribute(Attribute.Class(value));

		public HtmlButtonElement WithContentEditable(string value) => (HtmlButtonElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlButtonElement WithContextMenu(string value) => (HtmlButtonElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlButtonElement WithDir(string value) => (HtmlButtonElement)WithAttribute(Attribute.Dir(value));

		public HtmlButtonElement WithHidden(string value) => (HtmlButtonElement)WithAttribute(Attribute.Hidden(value));

		public HtmlButtonElement WithId(string value) => (HtmlButtonElement)WithAttribute(Attribute.Id(value));

		public HtmlButtonElement WithLang(string value) => (HtmlButtonElement)WithAttribute(Attribute.Lang(value));

		public HtmlButtonElement WithSpellCheck(string value) => (HtmlButtonElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlButtonElement WithStyle(string value) => (HtmlButtonElement)WithAttribute(Attribute.Style(value));

		public HtmlButtonElement WithTabIndex(string value) => (HtmlButtonElement)WithAttribute(Attribute.TabIndex(value));
    }
}
