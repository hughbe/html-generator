namespace HtmlGenerator
{
    public class HtmlDelElement : HtmlElement 
    {
        internal HtmlDelElement() : base("del", false) 
        {    
        }

		public HtmlDelElement WithCite(string value) => (HtmlDelElement)WithAttribute(Attribute.Cite(value));

		public HtmlDelElement WithDateTime(string value) => (HtmlDelElement)WithAttribute(Attribute.DateTime(value));

		public HtmlDelElement WithAccessKey(string value) => (HtmlDelElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDelElement WithClass(string value) => (HtmlDelElement)WithAttribute(Attribute.Class(value));

		public HtmlDelElement WithContentEditable(string value) => (HtmlDelElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDelElement WithContextMenu(string value) => (HtmlDelElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDelElement WithDir(string value) => (HtmlDelElement)WithAttribute(Attribute.Dir(value));

		public HtmlDelElement WithHidden(string value) => (HtmlDelElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDelElement WithId(string value) => (HtmlDelElement)WithAttribute(Attribute.Id(value));

		public HtmlDelElement WithLang(string value) => (HtmlDelElement)WithAttribute(Attribute.Lang(value));

		public HtmlDelElement WithSpellCheck(string value) => (HtmlDelElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDelElement WithStyle(string value) => (HtmlDelElement)WithAttribute(Attribute.Style(value));

		public HtmlDelElement WithTabIndex(string value) => (HtmlDelElement)WithAttribute(Attribute.TabIndex(value));
    }
}
