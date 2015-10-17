namespace HtmlGenerator
{
    public class HtmlPElement : HtmlElement 
    {
        internal HtmlPElement() : base("p", false) 
        {    
        }

		public HtmlPElement WithAccessKey(string value) => (HtmlPElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlPElement WithClass(string value) => (HtmlPElement)WithAttribute(Attribute.Class(value));

		public HtmlPElement WithContentEditable(string value) => (HtmlPElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlPElement WithContextMenuAttribute(string value) => (HtmlPElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlPElement WithDir(string value) => (HtmlPElement)WithAttribute(Attribute.Dir(value));

		public HtmlPElement WithHidden(string value) => (HtmlPElement)WithAttribute(Attribute.Hidden(value));

		public HtmlPElement WithId(string value) => (HtmlPElement)WithAttribute(Attribute.Id(value));

		public HtmlPElement WithLang(string value) => (HtmlPElement)WithAttribute(Attribute.Lang(value));

		public HtmlPElement WithSpellCheck(string value) => (HtmlPElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlPElement WithStyleAttribute(string value) => (HtmlPElement)WithAttribute(Attribute.Style(value));

		public HtmlPElement WithTabIndex(string value) => (HtmlPElement)WithAttribute(Attribute.TabIndex(value));
    }
}
