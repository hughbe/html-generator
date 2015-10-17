namespace HtmlGenerator
{
    public class HtmlMenuItemElement : HtmlElement 
    {
        public HtmlMenuItemElement() : base("menutiem", true) 
        {    
        }

		public HtmlMenuItemElement WithChecked() => (HtmlMenuItemElement)WithAttribute(Attribute.Checked);

		public HtmlMenuItemElement WithCommand(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Command(value));

		public HtmlMenuItemElement WithDefault() => (HtmlMenuItemElement)WithAttribute(Attribute.Default);

		public HtmlMenuItemElement WithDisabled() => (HtmlMenuItemElement)WithAttribute(Attribute.Disabled);

		public HtmlMenuItemElement WithIcon(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Icon(value));

		public HtmlMenuItemElement WithLabel(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Label(value));

		public HtmlMenuItemElement WithRadioGroup(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.RadioGroup(value));

		public HtmlMenuItemElement WithType(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Type(value));

		public HtmlMenuItemElement WithAccessKey(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMenuItemElement WithClass(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Class(value));

		public HtmlMenuItemElement WithContentEditable(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMenuItemElement WithContextMenu(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMenuItemElement WithDir(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Dir(value));

		public HtmlMenuItemElement WithHidden(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMenuItemElement WithId(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Id(value));

		public HtmlMenuItemElement WithLang(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Lang(value));

		public HtmlMenuItemElement WithSpellCheck(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMenuItemElement WithStyle(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Style(value));

		public HtmlMenuItemElement WithTabIndex(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.TabIndex(value));
    }
}
