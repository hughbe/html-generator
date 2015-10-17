namespace HtmlGenerator
{
    public class HtmlDlElement : HtmlElement 
    {
        internal HtmlDlElement() : base("dl", false) 
        {    
        }

		public HtmlDlElement WithCompact(string value) => (HtmlDlElement)WithAttribute(Attribute.Compact(value));

		public HtmlDlElement WithAccessKey(string value) => (HtmlDlElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDlElement WithClass(string value) => (HtmlDlElement)WithAttribute(Attribute.Class(value));

		public HtmlDlElement WithContentEditable(string value) => (HtmlDlElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDlElement WithContextMenu(string value) => (HtmlDlElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDlElement WithDir(string value) => (HtmlDlElement)WithAttribute(Attribute.Dir(value));

		public HtmlDlElement WithHidden(string value) => (HtmlDlElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDlElement WithId(string value) => (HtmlDlElement)WithAttribute(Attribute.Id(value));

		public HtmlDlElement WithLang(string value) => (HtmlDlElement)WithAttribute(Attribute.Lang(value));

		public HtmlDlElement WithSpellCheck(string value) => (HtmlDlElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDlElement WithStyle(string value) => (HtmlDlElement)WithAttribute(Attribute.Style(value));

		public HtmlDlElement WithTabIndex(string value) => (HtmlDlElement)WithAttribute(Attribute.TabIndex(value));
    }
}
