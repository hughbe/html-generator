namespace HtmlGenerator
{
    public class HtmlStyleElement : HtmlElement 
    {
        internal HtmlStyleElement() : base("style", false) 
        {    
        }

		public HtmlStyleElement WithDisabledAttribute() => (HtmlStyleElement)WithAttribute(Attribute.Disabled);

		public HtmlStyleElement WithTypeAttribute(string value) => (HtmlStyleElement)WithAttribute(Attribute.Type(value));

		public HtmlStyleElement WithMediaAttribute(string value) => (HtmlStyleElement)WithAttribute(Attribute.Media(value));

		public HtmlStyleElement WithScopedAttribute() => (HtmlStyleElement)WithAttribute(Attribute.Scoped);

		public HtmlStyleElement WithAccessKey(string value) => (HtmlStyleElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlStyleElement WithClass(string value) => (HtmlStyleElement)WithAttribute(Attribute.Class(value));

		public HtmlStyleElement WithContentEditable(string value) => (HtmlStyleElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlStyleElement WithContextMenuAttribute(string value) => (HtmlStyleElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlStyleElement WithDir(string value) => (HtmlStyleElement)WithAttribute(Attribute.Dir(value));

		public HtmlStyleElement WithHidden(string value) => (HtmlStyleElement)WithAttribute(Attribute.Hidden(value));

		public HtmlStyleElement WithId(string value) => (HtmlStyleElement)WithAttribute(Attribute.Id(value));

		public HtmlStyleElement WithLang(string value) => (HtmlStyleElement)WithAttribute(Attribute.Lang(value));

		public HtmlStyleElement WithSpellCheck(string value) => (HtmlStyleElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlStyleElement WithStyleAttribute(string value) => (HtmlStyleElement)WithAttribute(Attribute.Style(value));

		public HtmlStyleElement WithTabIndex(string value) => (HtmlStyleElement)WithAttribute(Attribute.TabIndex(value));
    }
}
