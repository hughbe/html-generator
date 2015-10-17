namespace HtmlGenerator
{
    public class HtmlOptionElement : HtmlElement 
    {
        internal HtmlOptionElement() : base("option", false) 
        {    
        }

		public HtmlOptionElement WithDisabledAttribute() => (HtmlOptionElement)WithAttribute(Attribute.Disabled);

		public HtmlOptionElement WithLabelAttribute(string value) => (HtmlOptionElement)WithAttribute(Attribute.Label(value));

		public HtmlOptionElement WithSelectedAttribute() => (HtmlOptionElement)WithAttribute(Attribute.Selected);

		public HtmlOptionElement WithValueAttribute(string value) => (HtmlOptionElement)WithAttribute(Attribute.Value(value));

		public HtmlOptionElement WithAccessKey(string value) => (HtmlOptionElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlOptionElement WithClass(string value) => (HtmlOptionElement)WithAttribute(Attribute.Class(value));

		public HtmlOptionElement WithContentEditable(string value) => (HtmlOptionElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlOptionElement WithContextMenuAttribute(string value) => (HtmlOptionElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlOptionElement WithDir(string value) => (HtmlOptionElement)WithAttribute(Attribute.Dir(value));

		public HtmlOptionElement WithHidden(string value) => (HtmlOptionElement)WithAttribute(Attribute.Hidden(value));

		public HtmlOptionElement WithId(string value) => (HtmlOptionElement)WithAttribute(Attribute.Id(value));

		public HtmlOptionElement WithLang(string value) => (HtmlOptionElement)WithAttribute(Attribute.Lang(value));

		public HtmlOptionElement WithSpellCheck(string value) => (HtmlOptionElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlOptionElement WithStyleAttribute(string value) => (HtmlOptionElement)WithAttribute(Attribute.Style(value));

		public HtmlOptionElement WithTabIndex(string value) => (HtmlOptionElement)WithAttribute(Attribute.TabIndex(value));
    }
}
