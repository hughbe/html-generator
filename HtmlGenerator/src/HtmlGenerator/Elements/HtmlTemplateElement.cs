namespace HtmlGenerator
{
    public class HtmlTemplateElement : HtmlElement 
    {
        internal HtmlTemplateElement() : base("template", false) 
        {    
        }

		public HtmlTemplateElement WithAccessKey(string value) => (HtmlTemplateElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTemplateElement WithClass(string value) => (HtmlTemplateElement)WithAttribute(Attribute.Class(value));

		public HtmlTemplateElement WithContentEditable(string value) => (HtmlTemplateElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTemplateElement WithContextMenu(string value) => (HtmlTemplateElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTemplateElement WithDir(string value) => (HtmlTemplateElement)WithAttribute(Attribute.Dir(value));

		public HtmlTemplateElement WithHidden(string value) => (HtmlTemplateElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTemplateElement WithId(string value) => (HtmlTemplateElement)WithAttribute(Attribute.Id(value));

		public HtmlTemplateElement WithLang(string value) => (HtmlTemplateElement)WithAttribute(Attribute.Lang(value));

		public HtmlTemplateElement WithSpellCheck(string value) => (HtmlTemplateElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTemplateElement WithStyle(string value) => (HtmlTemplateElement)WithAttribute(Attribute.Style(value));

		public HtmlTemplateElement WithTabIndex(string value) => (HtmlTemplateElement)WithAttribute(Attribute.TabIndex(value));
    }
}
