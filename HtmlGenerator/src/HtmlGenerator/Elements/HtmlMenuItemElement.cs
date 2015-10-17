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
    }
}
