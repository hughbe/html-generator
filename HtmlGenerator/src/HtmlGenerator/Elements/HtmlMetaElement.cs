namespace HtmlGenerator
{
    public class HtmlMetaElement : HtmlElement 
    {
        public HtmlMetaElement() : base("meta", true) 
        {    
        }

		public HtmlMetaElement WithCharset(string value) => (HtmlMetaElement)WithAttribute(Attribute.Charset(value));

		public new HtmlMetaElement WithContent(string value) => (HtmlMetaElement)WithAttribute(Attribute.Content(value));

		public HtmlMetaElement WithHttpEquiv(string value) => (HtmlMetaElement)WithAttribute(Attribute.HttpEquiv(value));

		public HtmlMetaElement WithDefaultStyle(string value) => (HtmlMetaElement)WithAttribute(Attribute.DefaultStyle(value));

		public HtmlMetaElement WithRefresh(string value) => (HtmlMetaElement)WithAttribute(Attribute.Refresh(value));

		public HtmlMetaElement WithName(string value) => (HtmlMetaElement)WithAttribute(Attribute.Name(value));

		public HtmlMetaElement WithAccessKey(string value) => (HtmlMetaElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMetaElement WithClass(string value) => (HtmlMetaElement)WithAttribute(Attribute.Class(value));

		public HtmlMetaElement WithContentEditable(string value) => (HtmlMetaElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMetaElement WithContextMenu(string value) => (HtmlMetaElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMetaElement WithDir(string value) => (HtmlMetaElement)WithAttribute(Attribute.Dir(value));

		public HtmlMetaElement WithHidden(string value) => (HtmlMetaElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMetaElement WithId(string value) => (HtmlMetaElement)WithAttribute(Attribute.Id(value));

		public HtmlMetaElement WithLang(string value) => (HtmlMetaElement)WithAttribute(Attribute.Lang(value));

		public HtmlMetaElement WithSpellCheck(string value) => (HtmlMetaElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMetaElement WithStyle(string value) => (HtmlMetaElement)WithAttribute(Attribute.Style(value));

		public HtmlMetaElement WithTabIndex(string value) => (HtmlMetaElement)WithAttribute(Attribute.TabIndex(value));
    }
}
