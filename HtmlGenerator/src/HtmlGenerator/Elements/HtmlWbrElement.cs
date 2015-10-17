namespace HtmlGenerator
{
    public class HtmlWbrElement : HtmlElement 
    {
        internal HtmlWbrElement() : base("wbr", false) 
        {    
        }

		public HtmlWbrElement WithAccessKey(string value) => (HtmlWbrElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlWbrElement WithClass(string value) => (HtmlWbrElement)WithAttribute(Attribute.Class(value));

		public HtmlWbrElement WithContentEditable(string value) => (HtmlWbrElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlWbrElement WithContextMenuAttribute(string value) => (HtmlWbrElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlWbrElement WithDir(string value) => (HtmlWbrElement)WithAttribute(Attribute.Dir(value));

		public HtmlWbrElement WithHidden(string value) => (HtmlWbrElement)WithAttribute(Attribute.Hidden(value));

		public HtmlWbrElement WithId(string value) => (HtmlWbrElement)WithAttribute(Attribute.Id(value));

		public HtmlWbrElement WithLang(string value) => (HtmlWbrElement)WithAttribute(Attribute.Lang(value));

		public HtmlWbrElement WithSpellCheck(string value) => (HtmlWbrElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlWbrElement WithStyleAttribute(string value) => (HtmlWbrElement)WithAttribute(Attribute.Style(value));

		public HtmlWbrElement WithTabIndex(string value) => (HtmlWbrElement)WithAttribute(Attribute.TabIndex(value));
    }
}
