namespace HtmlGenerator
{
    public class HtmlFieldsetElement : HtmlElement 
    {
        internal HtmlFieldsetElement() : base("fieldset", false) 
        {    
        }

		public HtmlFieldsetElement WithAccessKey(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlFieldsetElement WithClass(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.Class(value));

		public HtmlFieldsetElement WithContentEditable(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlFieldsetElement WithContextMenu(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlFieldsetElement WithDir(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.Dir(value));

		public HtmlFieldsetElement WithHidden(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.Hidden(value));

		public HtmlFieldsetElement WithId(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.Id(value));

		public HtmlFieldsetElement WithLang(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.Lang(value));

		public HtmlFieldsetElement WithSpellCheck(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlFieldsetElement WithStyle(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.Style(value));

		public HtmlFieldsetElement WithTabIndex(string value) => (HtmlFieldsetElement)WithAttribute(Attribute.TabIndex(value));
    }
}
