namespace HtmlGenerator
{
    public class HtmlInsElement : HtmlElement 
    {
        internal HtmlInsElement() : base("ins", false) 
        {    
        }

		public HtmlInsElement WithCiteAttribute(string value) => (HtmlInsElement)WithAttribute(Attribute.Cite(value));

		public HtmlInsElement WithDateTimeAttribute(string value) => (HtmlInsElement)WithAttribute(Attribute.DateTime(value));

		public HtmlInsElement WithAccessKey(string value) => (HtmlInsElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlInsElement WithClass(string value) => (HtmlInsElement)WithAttribute(Attribute.Class(value));

		public HtmlInsElement WithContentEditable(string value) => (HtmlInsElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlInsElement WithContextMenuAttribute(string value) => (HtmlInsElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlInsElement WithDir(string value) => (HtmlInsElement)WithAttribute(Attribute.Dir(value));

		public HtmlInsElement WithHidden(string value) => (HtmlInsElement)WithAttribute(Attribute.Hidden(value));

		public HtmlInsElement WithId(string value) => (HtmlInsElement)WithAttribute(Attribute.Id(value));

		public HtmlInsElement WithLang(string value) => (HtmlInsElement)WithAttribute(Attribute.Lang(value));

		public HtmlInsElement WithSpellCheck(string value) => (HtmlInsElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlInsElement WithStyleAttribute(string value) => (HtmlInsElement)WithAttribute(Attribute.Style(value));

		public HtmlInsElement WithTabIndex(string value) => (HtmlInsElement)WithAttribute(Attribute.TabIndex(value));
    }
}
