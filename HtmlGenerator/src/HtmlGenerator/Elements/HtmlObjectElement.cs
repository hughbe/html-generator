namespace HtmlGenerator
{
    public class HtmlObjectElement : HtmlElement 
    {
        internal HtmlObjectElement() : base("object", false) 
        {    
        }

		public HtmlObjectElement WithData(string value) => (HtmlObjectElement)WithAttribute(Attribute.Data(value));

		public HtmlObjectElement WithForm(string value) => (HtmlObjectElement)WithAttribute(Attribute.Form(value));

		public HtmlObjectElement WithHeight(string value) => (HtmlObjectElement)WithAttribute(Attribute.Height(value));

		public HtmlObjectElement WithName(string value) => (HtmlObjectElement)WithAttribute(Attribute.Name(value));

		public HtmlObjectElement WithType(string value) => (HtmlObjectElement)WithAttribute(Attribute.Type(value));

		public HtmlObjectElement WithTypeMustMatch() => (HtmlObjectElement)WithAttribute(Attribute.TypeMustMatch);

		public HtmlObjectElement WithUseMap(string value) => (HtmlObjectElement)WithAttribute(Attribute.UseMap(value));

		public HtmlObjectElement WithWidth(string value) => (HtmlObjectElement)WithAttribute(Attribute.Width(value));

		public HtmlObjectElement WithAccessKey(string value) => (HtmlObjectElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlObjectElement WithClass(string value) => (HtmlObjectElement)WithAttribute(Attribute.Class(value));

		public HtmlObjectElement WithContentEditable(string value) => (HtmlObjectElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlObjectElement WithContextMenu(string value) => (HtmlObjectElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlObjectElement WithDir(string value) => (HtmlObjectElement)WithAttribute(Attribute.Dir(value));

		public HtmlObjectElement WithHidden(string value) => (HtmlObjectElement)WithAttribute(Attribute.Hidden(value));

		public HtmlObjectElement WithId(string value) => (HtmlObjectElement)WithAttribute(Attribute.Id(value));

		public HtmlObjectElement WithLang(string value) => (HtmlObjectElement)WithAttribute(Attribute.Lang(value));

		public HtmlObjectElement WithSpellCheck(string value) => (HtmlObjectElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlObjectElement WithStyle(string value) => (HtmlObjectElement)WithAttribute(Attribute.Style(value));

		public HtmlObjectElement WithTabIndex(string value) => (HtmlObjectElement)WithAttribute(Attribute.TabIndex(value));
    }
}
