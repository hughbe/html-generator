namespace HtmlGenerator
{
    public class HtmlBdiElement : HtmlElement 
    {
        public HtmlBdiElement() : base("bdi", false) 
        {    
        }

		public HtmlBdiElement WithAccessKey(string value) => (HtmlBdiElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlBdiElement WithClass(string value) => (HtmlBdiElement)WithAttribute(Attribute.Class(value));

		public HtmlBdiElement WithContentEditable(string value) => (HtmlBdiElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlBdiElement WithContextMenu(string value) => (HtmlBdiElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlBdiElement WithDir(string value) => (HtmlBdiElement)WithAttribute(Attribute.Dir(value));

		public HtmlBdiElement WithHidden(string value) => (HtmlBdiElement)WithAttribute(Attribute.Hidden(value));

		public HtmlBdiElement WithId(string value) => (HtmlBdiElement)WithAttribute(Attribute.Id(value));

		public HtmlBdiElement WithLang(string value) => (HtmlBdiElement)WithAttribute(Attribute.Lang(value));

		public HtmlBdiElement WithSpellCheck(string value) => (HtmlBdiElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlBdiElement WithStyle(string value) => (HtmlBdiElement)WithAttribute(Attribute.Style(value));

		public HtmlBdiElement WithTabIndex(string value) => (HtmlBdiElement)WithAttribute(Attribute.TabIndex(value));
    }
}
