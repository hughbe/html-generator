namespace HtmlGenerator.Elements
{
    public class HtmlMenuItemElement : HtmlElement
    {
        public HtmlMenuItemElement() : base("menuitem") { }

        public HtmlMenuItemElement WithChecked() => this.WithAttribute(Attribute.Checked);

        public HtmlMenuItemElement WithCommand(string value) => this.WithAttribute(Attribute.Command(value));

        public HtmlMenuItemElement WithDefault() => this.WithAttribute(Attribute.Default);

        public HtmlMenuItemElement WithDisabled() => this.WithAttribute(Attribute.Disabled);

        public HtmlMenuItemElement WithIcon(string value) => this.WithAttribute(Attribute.Icon(value));

        public HtmlMenuItemElement WithLabel(string value) => this.WithAttribute(Attribute.Label(value));

        public HtmlMenuItemElement WithRadioGroup(string value) => this.WithAttribute(Attribute.RadioGroup(value));

        public HtmlMenuItemElement WithType(string value) => this.WithAttribute(Attribute.Type(value));
    }
}
