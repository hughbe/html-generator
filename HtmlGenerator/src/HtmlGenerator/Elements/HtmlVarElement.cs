namespace HtmlGenerator
{
    public class HtmlVarElement : HtmlElement 
    {
        public HtmlVarElement() : base("var", false) 
        {    
        }

		public HtmlVarElement WithAccessKey(string value) => (HtmlVarElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlVarElement WithClass(string value) => (HtmlVarElement)WithAttribute(Attribute.Class(value));

		public HtmlVarElement WithContentEditable(string value) => (HtmlVarElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlVarElement WithContextMenu(string value) => (HtmlVarElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlVarElement WithDir(string value) => (HtmlVarElement)WithAttribute(Attribute.Dir(value));

		public HtmlVarElement WithHidden(string value) => (HtmlVarElement)WithAttribute(Attribute.Hidden(value));

		public HtmlVarElement WithId(string value) => (HtmlVarElement)WithAttribute(Attribute.Id(value));

		public HtmlVarElement WithLang(string value) => (HtmlVarElement)WithAttribute(Attribute.Lang(value));

		public HtmlVarElement WithSpellCheck(string value) => (HtmlVarElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlVarElement WithStyle(string value) => (HtmlVarElement)WithAttribute(Attribute.Style(value));

		public HtmlVarElement WithTabIndex(string value) => (HtmlVarElement)WithAttribute(Attribute.TabIndex(value));
    }
}
