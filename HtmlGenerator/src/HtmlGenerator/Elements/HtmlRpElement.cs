namespace HtmlGenerator
{
    public class HtmlRpElement : HtmlElement 
    {
        public HtmlRpElement() : base("rp", false) 
        {    
        }

		public HtmlRpElement WithAccessKey(string value) => (HtmlRpElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlRpElement WithClass(string value) => (HtmlRpElement)WithAttribute(Attribute.Class(value));

		public HtmlRpElement WithContentEditable(string value) => (HtmlRpElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlRpElement WithContextMenu(string value) => (HtmlRpElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlRpElement WithDir(string value) => (HtmlRpElement)WithAttribute(Attribute.Dir(value));

		public HtmlRpElement WithHidden(string value) => (HtmlRpElement)WithAttribute(Attribute.Hidden(value));

		public HtmlRpElement WithId(string value) => (HtmlRpElement)WithAttribute(Attribute.Id(value));

		public HtmlRpElement WithLang(string value) => (HtmlRpElement)WithAttribute(Attribute.Lang(value));

		public HtmlRpElement WithSpellCheck(string value) => (HtmlRpElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlRpElement WithStyle(string value) => (HtmlRpElement)WithAttribute(Attribute.Style(value));

		public HtmlRpElement WithTabIndex(string value) => (HtmlRpElement)WithAttribute(Attribute.TabIndex(value));
    }
}
