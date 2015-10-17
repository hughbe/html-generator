namespace HtmlGenerator
{
    public class HtmlAElement : HtmlElement 
    {
        internal HtmlAElement() : base("a", false) 
        {    
        }

		public HtmlAElement WithDownloadAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Download(value));

		public HtmlAElement WithHrefAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Href(value));

		public HtmlAElement WithHrefLangAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.HrefLang(value));

		public HtmlAElement WithMediaAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Media(value));

		public HtmlAElement WithPingAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Ping(value));

		public HtmlAElement WithRelAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Rel(value));

		public HtmlAElement WithTargetAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Target(value));

		public HtmlAElement WithTypeAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Type(value));

		public HtmlAElement WithAccessKey(string value) => (HtmlAElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlAElement WithClass(string value) => (HtmlAElement)WithAttribute(Attribute.Class(value));

		public HtmlAElement WithContentEditable(string value) => (HtmlAElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlAElement WithContextMenuAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlAElement WithDir(string value) => (HtmlAElement)WithAttribute(Attribute.Dir(value));

		public HtmlAElement WithHidden(string value) => (HtmlAElement)WithAttribute(Attribute.Hidden(value));

		public HtmlAElement WithId(string value) => (HtmlAElement)WithAttribute(Attribute.Id(value));

		public HtmlAElement WithLang(string value) => (HtmlAElement)WithAttribute(Attribute.Lang(value));

		public HtmlAElement WithSpellCheck(string value) => (HtmlAElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlAElement WithStyleAttribute(string value) => (HtmlAElement)WithAttribute(Attribute.Style(value));

		public HtmlAElement WithTabIndex(string value) => (HtmlAElement)WithAttribute(Attribute.TabIndex(value));
    }
}
