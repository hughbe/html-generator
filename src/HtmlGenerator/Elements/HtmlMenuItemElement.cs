using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlMenuItemElement : HtmlElement
    {
        public HtmlMenuItemElement() : base("menuitem") 
        {    
        }

        public new HtmlMenuItemElement WithElement(HtmlElement element) => (HtmlMenuItemElement)base.WithElement(element);
        public new HtmlMenuItemElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlMenuItemElement)base.WithElements(elements);

        public new HtmlMenuItemElement WithInnerText(string innerText) => (HtmlMenuItemElement)base.WithInnerText(innerText);

        public new HtmlMenuItemElement WithAttribute(HtmlAttribute attribute) => (HtmlMenuItemElement)base.WithAttribute(attribute);
        public new HtmlMenuItemElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlMenuItemElement)base.WithAttributes(attributes);

		public HtmlMenuItemElement WithChecked() => WithAttribute(Attribute.Checked);

		public HtmlMenuItemElement WithCommand(string value) => WithAttribute(Attribute.Command(value));

		public HtmlMenuItemElement WithDefault() => WithAttribute(Attribute.Default);

		public HtmlMenuItemElement WithDisabled() => WithAttribute(Attribute.Disabled);

		public HtmlMenuItemElement WithIcon(string value) => WithAttribute(Attribute.Icon(value));

		public HtmlMenuItemElement WithLabel(string value) => WithAttribute(Attribute.Label(value));

		public HtmlMenuItemElement WithRadioGroup(string value) => WithAttribute(Attribute.RadioGroup(value));

		public HtmlMenuItemElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlMenuItemElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlMenuItemElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlMenuItemElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlMenuItemElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlMenuItemElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlMenuItemElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlMenuItemElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlMenuItemElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlMenuItemElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlMenuItemElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlMenuItemElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
