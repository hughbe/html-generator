namespace HtmlGenerator
{
    public class HtmlBrElement : HtmlElement 
    {
        internal HtmlBrElement() : base("br", true) 
        {    
        }

		public HtmlBrElement WithAccessKey(string value) => (HtmlBrElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlBrElement WithClass(string value) => (HtmlBrElement)WithAttribute(Attribute.Class(value));

		public HtmlBrElement WithContentEditable(string value) => (HtmlBrElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlBrElement WithContextMenuAttribute(string value) => (HtmlBrElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlBrElement WithDir(string value) => (HtmlBrElement)WithAttribute(Attribute.Dir(value));

		public HtmlBrElement WithHidden(string value) => (HtmlBrElement)WithAttribute(Attribute.Hidden(value));

		public HtmlBrElement WithId(string value) => (HtmlBrElement)WithAttribute(Attribute.Id(value));

		public HtmlBrElement WithLang(string value) => (HtmlBrElement)WithAttribute(Attribute.Lang(value));

		public HtmlBrElement WithSpellCheck(string value) => (HtmlBrElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlBrElement WithStyleAttribute(string value) => (HtmlBrElement)WithAttribute(Attribute.Style(value));

		public HtmlBrElement WithTabIndex(string value) => (HtmlBrElement)WithAttribute(Attribute.TabIndex(value));
    }
}
