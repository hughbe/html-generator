namespace HtmlGenerator
{
    public class HtmlSelectElement : HtmlElement 
    {
        public HtmlSelectElement() : base("select", false) 
        {    
        }

		public HtmlSelectElement WithAutoFocus() => (HtmlSelectElement)WithAttribute(Attribute.AutoFocus);

		public HtmlSelectElement WithDisabled() => (HtmlSelectElement)WithAttribute(Attribute.Disabled);

		public HtmlSelectElement WithForm(string value) => (HtmlSelectElement)WithAttribute(Attribute.Form(value));

		public HtmlSelectElement WithMultiple() => (HtmlSelectElement)WithAttribute(Attribute.Multiple);

		public HtmlSelectElement WithName(string value) => (HtmlSelectElement)WithAttribute(Attribute.Name(value));

		public HtmlSelectElement WithRequired() => (HtmlSelectElement)WithAttribute(Attribute.Required);

		public HtmlSelectElement WithSize(string value) => (HtmlSelectElement)WithAttribute(Attribute.Size(value));

		public HtmlSelectElement WithAccessKey(string value) => (HtmlSelectElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSelectElement WithClass(string value) => (HtmlSelectElement)WithAttribute(Attribute.Class(value));

		public HtmlSelectElement WithContentEditable(string value) => (HtmlSelectElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSelectElement WithContextMenu(string value) => (HtmlSelectElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSelectElement WithDir(string value) => (HtmlSelectElement)WithAttribute(Attribute.Dir(value));

		public HtmlSelectElement WithHidden(string value) => (HtmlSelectElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSelectElement WithId(string value) => (HtmlSelectElement)WithAttribute(Attribute.Id(value));

		public HtmlSelectElement WithLang(string value) => (HtmlSelectElement)WithAttribute(Attribute.Lang(value));

		public HtmlSelectElement WithSpellCheck(string value) => (HtmlSelectElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSelectElement WithStyle(string value) => (HtmlSelectElement)WithAttribute(Attribute.Style(value));

		public HtmlSelectElement WithTabIndex(string value) => (HtmlSelectElement)WithAttribute(Attribute.TabIndex(value));
    }
}
