namespace HtmlGenerator
{
    public class HtmlDataElement : HtmlElement 
    {
        internal HtmlDataElement() : base("data", false) 
        {    
        }

		public HtmlDataElement WithValueAttribute(string value) => (HtmlDataElement)WithAttribute(Attribute.Value(value));

		public HtmlDataElement WithAccessKey(string value) => (HtmlDataElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDataElement WithClass(string value) => (HtmlDataElement)WithAttribute(Attribute.Class(value));

		public HtmlDataElement WithContentEditable(string value) => (HtmlDataElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDataElement WithContextMenuAttribute(string value) => (HtmlDataElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDataElement WithDir(string value) => (HtmlDataElement)WithAttribute(Attribute.Dir(value));

		public HtmlDataElement WithHidden(string value) => (HtmlDataElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDataElement WithId(string value) => (HtmlDataElement)WithAttribute(Attribute.Id(value));

		public HtmlDataElement WithLang(string value) => (HtmlDataElement)WithAttribute(Attribute.Lang(value));

		public HtmlDataElement WithSpellCheck(string value) => (HtmlDataElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDataElement WithStyleAttribute(string value) => (HtmlDataElement)WithAttribute(Attribute.Style(value));

		public HtmlDataElement WithTabIndex(string value) => (HtmlDataElement)WithAttribute(Attribute.TabIndex(value));
    }
}
