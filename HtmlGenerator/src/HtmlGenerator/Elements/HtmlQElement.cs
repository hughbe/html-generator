namespace HtmlGenerator
{
    public class HtmlQElement : HtmlElement 
    {
        internal HtmlQElement() : base("q", false) 
        {    
        }

		public HtmlQElement WithCiteAttribute(string value) => (HtmlQElement)WithAttribute(Attribute.Cite(value));

		public HtmlQElement WithAccessKey(string value) => (HtmlQElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlQElement WithClass(string value) => (HtmlQElement)WithAttribute(Attribute.Class(value));

		public HtmlQElement WithContentEditable(string value) => (HtmlQElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlQElement WithContextMenuAttribute(string value) => (HtmlQElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlQElement WithDir(string value) => (HtmlQElement)WithAttribute(Attribute.Dir(value));

		public HtmlQElement WithHidden(string value) => (HtmlQElement)WithAttribute(Attribute.Hidden(value));

		public HtmlQElement WithId(string value) => (HtmlQElement)WithAttribute(Attribute.Id(value));

		public HtmlQElement WithLang(string value) => (HtmlQElement)WithAttribute(Attribute.Lang(value));

		public HtmlQElement WithSpellCheck(string value) => (HtmlQElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlQElement WithStyleAttribute(string value) => (HtmlQElement)WithAttribute(Attribute.Style(value));

		public HtmlQElement WithTabIndex(string value) => (HtmlQElement)WithAttribute(Attribute.TabIndex(value));
    }
}
