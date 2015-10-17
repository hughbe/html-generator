namespace HtmlGenerator
{
    public class HtmlLabelElement : HtmlElement 
    {
        public HtmlLabelElement() : base("label", false) 
        {    
        }

		public HtmlLabelElement WithFor(string value) => (HtmlLabelElement)WithAttribute(Attribute.For(value));

		public HtmlLabelElement WithForm(string value) => (HtmlLabelElement)WithAttribute(Attribute.Form(value));

		public HtmlLabelElement WithAccessKey(string value) => (HtmlLabelElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlLabelElement WithClass(string value) => (HtmlLabelElement)WithAttribute(Attribute.Class(value));

		public HtmlLabelElement WithContentEditable(string value) => (HtmlLabelElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlLabelElement WithContextMenu(string value) => (HtmlLabelElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlLabelElement WithDir(string value) => (HtmlLabelElement)WithAttribute(Attribute.Dir(value));

		public HtmlLabelElement WithHidden(string value) => (HtmlLabelElement)WithAttribute(Attribute.Hidden(value));

		public HtmlLabelElement WithId(string value) => (HtmlLabelElement)WithAttribute(Attribute.Id(value));

		public HtmlLabelElement WithLang(string value) => (HtmlLabelElement)WithAttribute(Attribute.Lang(value));

		public HtmlLabelElement WithSpellCheck(string value) => (HtmlLabelElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlLabelElement WithStyle(string value) => (HtmlLabelElement)WithAttribute(Attribute.Style(value));

		public HtmlLabelElement WithTabIndex(string value) => (HtmlLabelElement)WithAttribute(Attribute.TabIndex(value));
    }
}
