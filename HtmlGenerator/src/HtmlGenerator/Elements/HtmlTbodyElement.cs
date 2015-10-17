namespace HtmlGenerator
{
    public class HtmlTbodyElement : HtmlElement 
    {
        internal HtmlTbodyElement() : base("tbody", false) 
        {    
        }

		public HtmlTbodyElement WithAccessKey(string value) => (HtmlTbodyElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTbodyElement WithClass(string value) => (HtmlTbodyElement)WithAttribute(Attribute.Class(value));

		public HtmlTbodyElement WithContentEditable(string value) => (HtmlTbodyElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTbodyElement WithContextMenu(string value) => (HtmlTbodyElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTbodyElement WithDir(string value) => (HtmlTbodyElement)WithAttribute(Attribute.Dir(value));

		public HtmlTbodyElement WithHidden(string value) => (HtmlTbodyElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTbodyElement WithId(string value) => (HtmlTbodyElement)WithAttribute(Attribute.Id(value));

		public HtmlTbodyElement WithLang(string value) => (HtmlTbodyElement)WithAttribute(Attribute.Lang(value));

		public HtmlTbodyElement WithSpellCheck(string value) => (HtmlTbodyElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTbodyElement WithStyle(string value) => (HtmlTbodyElement)WithAttribute(Attribute.Style(value));

		public HtmlTbodyElement WithTabIndex(string value) => (HtmlTbodyElement)WithAttribute(Attribute.TabIndex(value));
    }
}
