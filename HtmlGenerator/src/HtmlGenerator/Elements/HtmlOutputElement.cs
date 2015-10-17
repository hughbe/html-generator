namespace HtmlGenerator
{
    public class HtmlOutputElement : HtmlElement 
    {
        public HtmlOutputElement() : base("output", false) 
        {    
        }

		public HtmlOutputElement WithFor(string value) => (HtmlOutputElement)WithAttribute(Attribute.For(value));

		public HtmlOutputElement WithForm(string value) => (HtmlOutputElement)WithAttribute(Attribute.Form(value));

		public HtmlOutputElement WithName(string value) => (HtmlOutputElement)WithAttribute(Attribute.Name(value));

		public HtmlOutputElement WithAccessKey(string value) => (HtmlOutputElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlOutputElement WithClass(string value) => (HtmlOutputElement)WithAttribute(Attribute.Class(value));

		public HtmlOutputElement WithContentEditable(string value) => (HtmlOutputElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlOutputElement WithContextMenu(string value) => (HtmlOutputElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlOutputElement WithDir(string value) => (HtmlOutputElement)WithAttribute(Attribute.Dir(value));

		public HtmlOutputElement WithHidden(string value) => (HtmlOutputElement)WithAttribute(Attribute.Hidden(value));

		public HtmlOutputElement WithId(string value) => (HtmlOutputElement)WithAttribute(Attribute.Id(value));

		public HtmlOutputElement WithLang(string value) => (HtmlOutputElement)WithAttribute(Attribute.Lang(value));

		public HtmlOutputElement WithSpellCheck(string value) => (HtmlOutputElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlOutputElement WithStyle(string value) => (HtmlOutputElement)WithAttribute(Attribute.Style(value));

		public HtmlOutputElement WithTabIndex(string value) => (HtmlOutputElement)WithAttribute(Attribute.TabIndex(value));
    }
}
