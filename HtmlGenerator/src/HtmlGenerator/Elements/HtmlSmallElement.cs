namespace HtmlGenerator
{
    public class HtmlSmallElement : HtmlElement 
    {
        internal HtmlSmallElement() : base("small", false) 
        {    
        }

		public HtmlSmallElement WithAccessKey(string value) => (HtmlSmallElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlSmallElement WithClass(string value) => (HtmlSmallElement)WithAttribute(Attribute.Class(value));

		public HtmlSmallElement WithContentEditable(string value) => (HtmlSmallElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlSmallElement WithContextMenuAttribute(string value) => (HtmlSmallElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlSmallElement WithDir(string value) => (HtmlSmallElement)WithAttribute(Attribute.Dir(value));

		public HtmlSmallElement WithHidden(string value) => (HtmlSmallElement)WithAttribute(Attribute.Hidden(value));

		public HtmlSmallElement WithId(string value) => (HtmlSmallElement)WithAttribute(Attribute.Id(value));

		public HtmlSmallElement WithLang(string value) => (HtmlSmallElement)WithAttribute(Attribute.Lang(value));

		public HtmlSmallElement WithSpellCheck(string value) => (HtmlSmallElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlSmallElement WithStyleAttribute(string value) => (HtmlSmallElement)WithAttribute(Attribute.Style(value));

		public HtmlSmallElement WithTabIndex(string value) => (HtmlSmallElement)WithAttribute(Attribute.TabIndex(value));
    }
}
