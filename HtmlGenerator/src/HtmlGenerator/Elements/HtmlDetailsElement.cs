namespace HtmlGenerator
{
    public class HtmlDetailsElement : HtmlElement 
    {
        internal HtmlDetailsElement() : base("details", false) 
        {    
        }

		public HtmlDetailsElement WithOpen(string value) => (HtmlDetailsElement)WithAttribute(Attribute.Open(value));

		public HtmlDetailsElement WithAccessKey(string value) => (HtmlDetailsElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDetailsElement WithClass(string value) => (HtmlDetailsElement)WithAttribute(Attribute.Class(value));

		public HtmlDetailsElement WithContentEditable(string value) => (HtmlDetailsElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDetailsElement WithContextMenu(string value) => (HtmlDetailsElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDetailsElement WithDir(string value) => (HtmlDetailsElement)WithAttribute(Attribute.Dir(value));

		public HtmlDetailsElement WithHidden(string value) => (HtmlDetailsElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDetailsElement WithId(string value) => (HtmlDetailsElement)WithAttribute(Attribute.Id(value));

		public HtmlDetailsElement WithLang(string value) => (HtmlDetailsElement)WithAttribute(Attribute.Lang(value));

		public HtmlDetailsElement WithSpellCheck(string value) => (HtmlDetailsElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDetailsElement WithStyle(string value) => (HtmlDetailsElement)WithAttribute(Attribute.Style(value));

		public HtmlDetailsElement WithTabIndex(string value) => (HtmlDetailsElement)WithAttribute(Attribute.TabIndex(value));
    }
}
