namespace HtmlGenerator
{
    public class HtmlLiElement : HtmlElement 
    {
        internal HtmlLiElement() : base("li", false) 
        {    
        }

		public HtmlLiElement WithValueAttribute(string value) => (HtmlLiElement)WithAttribute(Attribute.Value(value));

		public HtmlLiElement WithAccessKey(string value) => (HtmlLiElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlLiElement WithClass(string value) => (HtmlLiElement)WithAttribute(Attribute.Class(value));

		public HtmlLiElement WithContentEditable(string value) => (HtmlLiElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlLiElement WithContextMenuAttribute(string value) => (HtmlLiElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlLiElement WithDir(string value) => (HtmlLiElement)WithAttribute(Attribute.Dir(value));

		public HtmlLiElement WithHidden(string value) => (HtmlLiElement)WithAttribute(Attribute.Hidden(value));

		public HtmlLiElement WithId(string value) => (HtmlLiElement)WithAttribute(Attribute.Id(value));

		public HtmlLiElement WithLang(string value) => (HtmlLiElement)WithAttribute(Attribute.Lang(value));

		public HtmlLiElement WithSpellCheck(string value) => (HtmlLiElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlLiElement WithStyleAttribute(string value) => (HtmlLiElement)WithAttribute(Attribute.Style(value));

		public HtmlLiElement WithTabIndex(string value) => (HtmlLiElement)WithAttribute(Attribute.TabIndex(value));
    }
}
