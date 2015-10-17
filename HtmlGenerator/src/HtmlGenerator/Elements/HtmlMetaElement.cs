namespace HtmlGenerator
{
    public class HtmlMetaElement : HtmlElement 
    {
        internal HtmlMetaElement() : base("meta", true) 
        {    
        }

		public HtmlMetaElement WithCharsetAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.Charset(value));

		public HtmlMetaElement WithContentAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.Content(value));

		public HtmlMetaElement WithHttpEquivAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.HttpEquiv(value));

		public HtmlMetaElement WithDefaultStyleAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.DefaultStyle(value));

		public HtmlMetaElement WithRefreshAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.Refresh(value));

		public HtmlMetaElement WithNameAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.Name(value));

		public HtmlMetaElement WithAccessKey(string value) => (HtmlMetaElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMetaElement WithClass(string value) => (HtmlMetaElement)WithAttribute(Attribute.Class(value));

		public HtmlMetaElement WithContentEditable(string value) => (HtmlMetaElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMetaElement WithContextMenuAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMetaElement WithDir(string value) => (HtmlMetaElement)WithAttribute(Attribute.Dir(value));

		public HtmlMetaElement WithHidden(string value) => (HtmlMetaElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMetaElement WithId(string value) => (HtmlMetaElement)WithAttribute(Attribute.Id(value));

		public HtmlMetaElement WithLang(string value) => (HtmlMetaElement)WithAttribute(Attribute.Lang(value));

		public HtmlMetaElement WithSpellCheck(string value) => (HtmlMetaElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMetaElement WithStyleAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.Style(value));

		public HtmlMetaElement WithTabIndex(string value) => (HtmlMetaElement)WithAttribute(Attribute.TabIndex(value));
    }
}
