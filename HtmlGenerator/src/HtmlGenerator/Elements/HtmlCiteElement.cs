namespace HtmlGenerator
{
    public class HtmlCiteElement : HtmlElement 
    {
        internal HtmlCiteElement() : base("cite", false) 
        {    
        }

		public HtmlCiteElement WithAccessKey(string value) => (HtmlCiteElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlCiteElement WithClass(string value) => (HtmlCiteElement)WithAttribute(Attribute.Class(value));

		public HtmlCiteElement WithContentEditable(string value) => (HtmlCiteElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlCiteElement WithContextMenu(string value) => (HtmlCiteElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlCiteElement WithDir(string value) => (HtmlCiteElement)WithAttribute(Attribute.Dir(value));

		public HtmlCiteElement WithHidden(string value) => (HtmlCiteElement)WithAttribute(Attribute.Hidden(value));

		public HtmlCiteElement WithId(string value) => (HtmlCiteElement)WithAttribute(Attribute.Id(value));

		public HtmlCiteElement WithLang(string value) => (HtmlCiteElement)WithAttribute(Attribute.Lang(value));

		public HtmlCiteElement WithSpellCheck(string value) => (HtmlCiteElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlCiteElement WithStyle(string value) => (HtmlCiteElement)WithAttribute(Attribute.Style(value));

		public HtmlCiteElement WithTabIndex(string value) => (HtmlCiteElement)WithAttribute(Attribute.TabIndex(value));
    }
}
