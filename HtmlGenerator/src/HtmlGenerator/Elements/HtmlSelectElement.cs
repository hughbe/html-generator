namespace HtmlGenerator
{
    public class HtmlSelectElement : HtmlElement 
    {
        internal HtmlSelectElement() : base("select", false) 
        {    
        }

		public HtmlSelectElement WithAutoFocusAttribute() => (HtmlSelectElement)WithAttribute(Attribute.AutoFocus);

		public HtmlSelectElement WithDisabledAttribute() => (HtmlSelectElement)WithAttribute(Attribute.Disabled);

		public HtmlSelectElement WithFormAttribute(string value) => (HtmlSelectElement)WithAttribute(Attribute.Form(value));

		public HtmlSelectElement WithMultipleAttribute() => (HtmlSelectElement)WithAttribute(Attribute.Multiple);

		public HtmlSelectElement WithNameAttribute(string value) => (HtmlSelectElement)WithAttribute(Attribute.Name(value));

		public HtmlSelectElement WithRequiredAttribute() => (HtmlSelectElement)WithAttribute(Attribute.Required);

		public HtmlSelectElement WithSizeAttribute(string value) => (HtmlSelectElement)WithAttribute(Attribute.Size(value));

		public HtmlSelectElement WithAccessKey(string value) => (HtmlSelectElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSelectElement WithClass(string value) => (HtmlSelectElement)WithAttribute(Attribute.Class(value));

		public HtmlSelectElement WithContentEditable(string value) => (HtmlSelectElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSelectElement WithContextMenuAttribute(string value) => (HtmlSelectElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSelectElement WithDir(string value) => (HtmlSelectElement)WithAttribute(Attribute.Dir(value));

		public HtmlSelectElement WithHidden(string value) => (HtmlSelectElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSelectElement WithId(string value) => (HtmlSelectElement)WithAttribute(Attribute.Id(value));

		public HtmlSelectElement WithLang(string value) => (HtmlSelectElement)WithAttribute(Attribute.Lang(value));

		public HtmlSelectElement WithSpellCheck(string value) => (HtmlSelectElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSelectElement WithStyleAttribute(string value) => (HtmlSelectElement)WithAttribute(Attribute.Style(value));

		public HtmlSelectElement WithTabIndex(string value) => (HtmlSelectElement)WithAttribute(Attribute.TabIndex(value));
    }
}
