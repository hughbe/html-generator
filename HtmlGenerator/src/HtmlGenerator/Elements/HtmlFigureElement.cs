namespace HtmlGenerator
{
    public class HtmlFigureElement : HtmlElement 
    {
        internal HtmlFigureElement() : base("figure", false) 
        {    
        }

		public HtmlFigureElement WithAccessKey(string value) => (HtmlFigureElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlFigureElement WithClass(string value) => (HtmlFigureElement)WithAttribute(Attribute.Class(value));

		public HtmlFigureElement WithContentEditable(string value) => (HtmlFigureElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlFigureElement WithContextMenu(string value) => (HtmlFigureElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlFigureElement WithDir(string value) => (HtmlFigureElement)WithAttribute(Attribute.Dir(value));

		public HtmlFigureElement WithHidden(string value) => (HtmlFigureElement)WithAttribute(Attribute.Hidden(value));

		public HtmlFigureElement WithId(string value) => (HtmlFigureElement)WithAttribute(Attribute.Id(value));

		public HtmlFigureElement WithLang(string value) => (HtmlFigureElement)WithAttribute(Attribute.Lang(value));

		public HtmlFigureElement WithSpellCheck(string value) => (HtmlFigureElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlFigureElement WithStyle(string value) => (HtmlFigureElement)WithAttribute(Attribute.Style(value));

		public HtmlFigureElement WithTabIndex(string value) => (HtmlFigureElement)WithAttribute(Attribute.TabIndex(value));
    }
}
