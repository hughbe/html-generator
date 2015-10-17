namespace HtmlGenerator
{
    public class HtmlMapElement : HtmlElement 
    {
        public HtmlMapElement() : base("map", false) 
        {    
        }

		public HtmlMapElement WithName(string value) => (HtmlMapElement)WithAttribute(Attribute.Name(value));

		public HtmlMapElement WithAccessKey(string value) => (HtmlMapElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMapElement WithClass(string value) => (HtmlMapElement)WithAttribute(Attribute.Class(value));

		public HtmlMapElement WithContentEditable(string value) => (HtmlMapElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMapElement WithContextMenu(string value) => (HtmlMapElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMapElement WithDir(string value) => (HtmlMapElement)WithAttribute(Attribute.Dir(value));

		public HtmlMapElement WithHidden(string value) => (HtmlMapElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMapElement WithId(string value) => (HtmlMapElement)WithAttribute(Attribute.Id(value));

		public HtmlMapElement WithLang(string value) => (HtmlMapElement)WithAttribute(Attribute.Lang(value));

		public HtmlMapElement WithSpellCheck(string value) => (HtmlMapElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMapElement WithStyle(string value) => (HtmlMapElement)WithAttribute(Attribute.Style(value));

		public HtmlMapElement WithTabIndex(string value) => (HtmlMapElement)WithAttribute(Attribute.TabIndex(value));
    }
}
