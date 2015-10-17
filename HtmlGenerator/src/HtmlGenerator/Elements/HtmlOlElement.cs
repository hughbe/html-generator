namespace HtmlGenerator
{
    public class HtmlOlElement : HtmlElement 
    {
        public HtmlOlElement() : base("ol", false) 
        {    
        }

		public HtmlOlElement WithReversed(string value) => (HtmlOlElement)WithAttribute(Attribute.Reversed(value));

		public HtmlOlElement WithStart(string value) => (HtmlOlElement)WithAttribute(Attribute.Start(value));

		public HtmlOlElement WithType(string value) => (HtmlOlElement)WithAttribute(Attribute.Type(value));

		public HtmlOlElement WithAccessKey(string value) => (HtmlOlElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlOlElement WithClass(string value) => (HtmlOlElement)WithAttribute(Attribute.Class(value));

		public HtmlOlElement WithContentEditable(string value) => (HtmlOlElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlOlElement WithContextMenu(string value) => (HtmlOlElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlOlElement WithDir(string value) => (HtmlOlElement)WithAttribute(Attribute.Dir(value));

		public HtmlOlElement WithHidden(string value) => (HtmlOlElement)WithAttribute(Attribute.Hidden(value));

		public HtmlOlElement WithId(string value) => (HtmlOlElement)WithAttribute(Attribute.Id(value));

		public HtmlOlElement WithLang(string value) => (HtmlOlElement)WithAttribute(Attribute.Lang(value));

		public HtmlOlElement WithSpellCheck(string value) => (HtmlOlElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlOlElement WithStyle(string value) => (HtmlOlElement)WithAttribute(Attribute.Style(value));

		public HtmlOlElement WithTabIndex(string value) => (HtmlOlElement)WithAttribute(Attribute.TabIndex(value));
    }
}
