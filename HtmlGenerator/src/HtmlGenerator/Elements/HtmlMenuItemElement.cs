namespace HtmlGenerator
{
    public class HtmlMenuItemElement : HtmlElement 
    {
        internal HtmlMenuItemElement() : base("menutiem", true) 
        {    
        }

		public HtmlMenuItemElement WithCheckedAttribute() => (HtmlMenuItemElement)WithAttribute(Attribute.Checked);

		public HtmlMenuItemElement WithCommandAttribute(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Command(value));

		public HtmlMenuItemElement WithDefaultAttribute() => (HtmlMenuItemElement)WithAttribute(Attribute.Default);

		public HtmlMenuItemElement WithDisabledAttribute() => (HtmlMenuItemElement)WithAttribute(Attribute.Disabled);

		public HtmlMenuItemElement WithIconAttribute(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Icon(value));

		public HtmlMenuItemElement WithLabelAttribute(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Label(value));

		public HtmlMenuItemElement WithRadioGroupAttribute(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.RadioGroup(value));

		public HtmlMenuItemElement WithTypeAttribute(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Type(value));

		public HtmlMenuItemElement WithAccessKey(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMenuItemElement WithClass(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Class(value));

		public HtmlMenuItemElement WithContentEditable(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMenuItemElement WithContextMenuAttribute(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMenuItemElement WithDir(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Dir(value));

		public HtmlMenuItemElement WithHidden(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMenuItemElement WithId(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Id(value));

		public HtmlMenuItemElement WithLang(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Lang(value));

		public HtmlMenuItemElement WithSpellCheck(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMenuItemElement WithStyleAttribute(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.Style(value));

		public HtmlMenuItemElement WithTabIndex(string value) => (HtmlMenuItemElement)WithAttribute(Attribute.TabIndex(value));
    }
}
