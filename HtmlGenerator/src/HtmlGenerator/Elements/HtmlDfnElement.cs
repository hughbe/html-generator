namespace HtmlGenerator
{
    public class HtmlDfnElement : HtmlElement 
    {
        public HtmlDfnElement() : base("dfn", false) 
        {    
        }

		public HtmlDfnElement WithAccessKey(string value) => (HtmlDfnElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDfnElement WithClass(string value) => (HtmlDfnElement)WithAttribute(Attribute.Class(value));

		public HtmlDfnElement WithContentEditable(string value) => (HtmlDfnElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDfnElement WithContextMenu(string value) => (HtmlDfnElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDfnElement WithDir(string value) => (HtmlDfnElement)WithAttribute(Attribute.Dir(value));

		public HtmlDfnElement WithHidden(string value) => (HtmlDfnElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDfnElement WithId(string value) => (HtmlDfnElement)WithAttribute(Attribute.Id(value));

		public HtmlDfnElement WithLang(string value) => (HtmlDfnElement)WithAttribute(Attribute.Lang(value));

		public HtmlDfnElement WithSpellCheck(string value) => (HtmlDfnElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDfnElement WithStyle(string value) => (HtmlDfnElement)WithAttribute(Attribute.Style(value));

		public HtmlDfnElement WithTabIndex(string value) => (HtmlDfnElement)WithAttribute(Attribute.TabIndex(value));
    }
}
