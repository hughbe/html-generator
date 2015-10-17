namespace HtmlGenerator
{
    public class HtmlEmbedElement : HtmlElement 
    {
        internal HtmlEmbedElement() : base("embed", true) 
        {    
        }

		public HtmlEmbedElement WithHeight(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Height(value));

		public HtmlEmbedElement WithSrc(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Src(value));

		public HtmlEmbedElement WithType(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Type(value));

		public HtmlEmbedElement WithWidth(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Width(value));

		public HtmlEmbedElement WithAccessKey(string value) => (HtmlEmbedElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlEmbedElement WithClass(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Class(value));

		public HtmlEmbedElement WithContentEditable(string value) => (HtmlEmbedElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlEmbedElement WithContextMenu(string value) => (HtmlEmbedElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlEmbedElement WithDir(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Dir(value));

		public HtmlEmbedElement WithHidden(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Hidden(value));

		public HtmlEmbedElement WithId(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Id(value));

		public HtmlEmbedElement WithLang(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Lang(value));

		public HtmlEmbedElement WithSpellCheck(string value) => (HtmlEmbedElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlEmbedElement WithStyle(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Style(value));

		public HtmlEmbedElement WithTabIndex(string value) => (HtmlEmbedElement)WithAttribute(Attribute.TabIndex(value));
    }
}
