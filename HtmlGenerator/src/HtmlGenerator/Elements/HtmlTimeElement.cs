namespace HtmlGenerator
{
    public class HtmlTimeElement : HtmlElement 
    {
        internal HtmlTimeElement() : base("time", false) 
        {    
        }

		public HtmlTimeElement WithDateTime(string value) => (HtmlTimeElement)WithAttribute(Attribute.DateTime(value));

		public HtmlTimeElement WithAccessKey(string value) => (HtmlTimeElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTimeElement WithClass(string value) => (HtmlTimeElement)WithAttribute(Attribute.Class(value));

		public HtmlTimeElement WithContentEditable(string value) => (HtmlTimeElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTimeElement WithContextMenu(string value) => (HtmlTimeElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTimeElement WithDir(string value) => (HtmlTimeElement)WithAttribute(Attribute.Dir(value));

		public HtmlTimeElement WithHidden(string value) => (HtmlTimeElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTimeElement WithId(string value) => (HtmlTimeElement)WithAttribute(Attribute.Id(value));

		public HtmlTimeElement WithLang(string value) => (HtmlTimeElement)WithAttribute(Attribute.Lang(value));

		public HtmlTimeElement WithSpellCheck(string value) => (HtmlTimeElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTimeElement WithStyle(string value) => (HtmlTimeElement)WithAttribute(Attribute.Style(value));

		public HtmlTimeElement WithTabIndex(string value) => (HtmlTimeElement)WithAttribute(Attribute.TabIndex(value));
    }
}
