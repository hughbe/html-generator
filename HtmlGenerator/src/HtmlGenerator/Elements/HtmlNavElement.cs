namespace HtmlGenerator
{
    public class HtmlNavElement : HtmlElement 
    {
        internal HtmlNavElement() : base("nav", false) 
        {    
        }

		public HtmlNavElement WithAccessKey(string value) => (HtmlNavElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlNavElement WithClass(string value) => (HtmlNavElement)WithAttribute(Attribute.Class(value));

		public HtmlNavElement WithContentEditable(string value) => (HtmlNavElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlNavElement WithContextMenuAttribute(string value) => (HtmlNavElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlNavElement WithDir(string value) => (HtmlNavElement)WithAttribute(Attribute.Dir(value));

		public HtmlNavElement WithHidden(string value) => (HtmlNavElement)WithAttribute(Attribute.Hidden(value));

		public HtmlNavElement WithId(string value) => (HtmlNavElement)WithAttribute(Attribute.Id(value));

		public HtmlNavElement WithLang(string value) => (HtmlNavElement)WithAttribute(Attribute.Lang(value));

		public HtmlNavElement WithSpellCheck(string value) => (HtmlNavElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlNavElement WithStyleAttribute(string value) => (HtmlNavElement)WithAttribute(Attribute.Style(value));

		public HtmlNavElement WithTabIndex(string value) => (HtmlNavElement)WithAttribute(Attribute.TabIndex(value));
    }
}
