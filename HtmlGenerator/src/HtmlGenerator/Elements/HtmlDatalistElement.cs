namespace HtmlGenerator
{
    public class HtmlDatalistElement : HtmlElement 
    {
        public HtmlDatalistElement() : base("datalist", false) 
        {    
        }

		public HtmlDatalistElement WithAccessKey(string value) => (HtmlDatalistElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDatalistElement WithClass(string value) => (HtmlDatalistElement)WithAttribute(Attribute.Class(value));

		public HtmlDatalistElement WithContentEditable(string value) => (HtmlDatalistElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDatalistElement WithContextMenu(string value) => (HtmlDatalistElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDatalistElement WithDir(string value) => (HtmlDatalistElement)WithAttribute(Attribute.Dir(value));

		public HtmlDatalistElement WithHidden(string value) => (HtmlDatalistElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDatalistElement WithId(string value) => (HtmlDatalistElement)WithAttribute(Attribute.Id(value));

		public HtmlDatalistElement WithLang(string value) => (HtmlDatalistElement)WithAttribute(Attribute.Lang(value));

		public HtmlDatalistElement WithSpellCheck(string value) => (HtmlDatalistElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDatalistElement WithStyle(string value) => (HtmlDatalistElement)WithAttribute(Attribute.Style(value));

		public HtmlDatalistElement WithTabIndex(string value) => (HtmlDatalistElement)WithAttribute(Attribute.TabIndex(value));
    }
}
