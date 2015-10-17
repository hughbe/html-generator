namespace HtmlGenerator
{
    public class HtmlPreElement : HtmlElement 
    {
        internal HtmlPreElement() : base("pre", false) 
        {    
        }

		public HtmlPreElement WithAccessKey(string value) => (HtmlPreElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlPreElement WithClass(string value) => (HtmlPreElement)WithAttribute(Attribute.Class(value));

		public HtmlPreElement WithContentEditable(string value) => (HtmlPreElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlPreElement WithContextMenuAttribute(string value) => (HtmlPreElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlPreElement WithDir(string value) => (HtmlPreElement)WithAttribute(Attribute.Dir(value));

		public HtmlPreElement WithHidden(string value) => (HtmlPreElement)WithAttribute(Attribute.Hidden(value));

		public HtmlPreElement WithId(string value) => (HtmlPreElement)WithAttribute(Attribute.Id(value));

		public HtmlPreElement WithLang(string value) => (HtmlPreElement)WithAttribute(Attribute.Lang(value));

		public HtmlPreElement WithSpellCheck(string value) => (HtmlPreElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlPreElement WithStyleAttribute(string value) => (HtmlPreElement)WithAttribute(Attribute.Style(value));

		public HtmlPreElement WithTabIndex(string value) => (HtmlPreElement)WithAttribute(Attribute.TabIndex(value));
    }
}
