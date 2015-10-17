namespace HtmlGenerator
{
    public class HtmlTrElement : HtmlElement 
    {
        internal HtmlTrElement() : base("tr", false) 
        {    
        }

		public HtmlTrElement WithAccessKey(string value) => (HtmlTrElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTrElement WithClass(string value) => (HtmlTrElement)WithAttribute(Attribute.Class(value));

		public HtmlTrElement WithContentEditable(string value) => (HtmlTrElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTrElement WithContextMenuAttribute(string value) => (HtmlTrElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTrElement WithDir(string value) => (HtmlTrElement)WithAttribute(Attribute.Dir(value));

		public HtmlTrElement WithHidden(string value) => (HtmlTrElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTrElement WithId(string value) => (HtmlTrElement)WithAttribute(Attribute.Id(value));

		public HtmlTrElement WithLang(string value) => (HtmlTrElement)WithAttribute(Attribute.Lang(value));

		public HtmlTrElement WithSpellCheck(string value) => (HtmlTrElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTrElement WithStyleAttribute(string value) => (HtmlTrElement)WithAttribute(Attribute.Style(value));

		public HtmlTrElement WithTabIndex(string value) => (HtmlTrElement)WithAttribute(Attribute.TabIndex(value));
    }
}
