namespace HtmlGenerator
{
    public class HtmlSampElement : HtmlElement 
    {
        public HtmlSampElement() : base("samp", false) 
        {    
        }

		public HtmlSampElement WithAccessKey(string value) => (HtmlSampElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSampElement WithClass(string value) => (HtmlSampElement)WithAttribute(Attribute.Class(value));

		public HtmlSampElement WithContentEditable(string value) => (HtmlSampElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSampElement WithContextMenu(string value) => (HtmlSampElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSampElement WithDir(string value) => (HtmlSampElement)WithAttribute(Attribute.Dir(value));

		public HtmlSampElement WithHidden(string value) => (HtmlSampElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSampElement WithId(string value) => (HtmlSampElement)WithAttribute(Attribute.Id(value));

		public HtmlSampElement WithLang(string value) => (HtmlSampElement)WithAttribute(Attribute.Lang(value));

		public HtmlSampElement WithSpellCheck(string value) => (HtmlSampElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSampElement WithStyle(string value) => (HtmlSampElement)WithAttribute(Attribute.Style(value));

		public HtmlSampElement WithTabIndex(string value) => (HtmlSampElement)WithAttribute(Attribute.TabIndex(value));
    }
}
