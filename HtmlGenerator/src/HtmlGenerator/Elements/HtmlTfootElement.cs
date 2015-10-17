namespace HtmlGenerator
{
    public class HtmlTfootElement : HtmlElement 
    {
        public HtmlTfootElement() : base("tfoot", false) 
        {    
        }

		public HtmlTfootElement WithAccessKey(string value) => (HtmlTfootElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlTfootElement WithClass(string value) => (HtmlTfootElement)WithAttribute(Attribute.Class(value));

		public HtmlTfootElement WithContentEditable(string value) => (HtmlTfootElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlTfootElement WithContextMenu(string value) => (HtmlTfootElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlTfootElement WithDir(string value) => (HtmlTfootElement)WithAttribute(Attribute.Dir(value));

		public HtmlTfootElement WithHidden(string value) => (HtmlTfootElement)WithAttribute(Attribute.Hidden(value));

		public HtmlTfootElement WithId(string value) => (HtmlTfootElement)WithAttribute(Attribute.Id(value));

		public HtmlTfootElement WithLang(string value) => (HtmlTfootElement)WithAttribute(Attribute.Lang(value));

		public HtmlTfootElement WithSpellCheck(string value) => (HtmlTfootElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlTfootElement WithStyle(string value) => (HtmlTfootElement)WithAttribute(Attribute.Style(value));

		public HtmlTfootElement WithTabIndex(string value) => (HtmlTfootElement)WithAttribute(Attribute.TabIndex(value));
    }
}
