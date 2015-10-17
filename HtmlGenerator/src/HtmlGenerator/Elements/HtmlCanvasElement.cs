namespace HtmlGenerator
{
    public class HtmlCanvasElement : HtmlElement 
    {
        public HtmlCanvasElement() : base("canvas", false) 
        {    
        }

		public HtmlCanvasElement WithHeight(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Height(value));

		public HtmlCanvasElement WithWidth(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Width(value));

		public HtmlCanvasElement WithAccessKey(string value) => (HtmlCanvasElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlCanvasElement WithClass(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Class(value));

		public HtmlCanvasElement WithContentEditable(string value) => (HtmlCanvasElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlCanvasElement WithContextMenu(string value) => (HtmlCanvasElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlCanvasElement WithDir(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Dir(value));

		public HtmlCanvasElement WithHidden(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Hidden(value));

		public HtmlCanvasElement WithId(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Id(value));

		public HtmlCanvasElement WithLang(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Lang(value));

		public HtmlCanvasElement WithSpellCheck(string value) => (HtmlCanvasElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlCanvasElement WithStyle(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Style(value));

		public HtmlCanvasElement WithTabIndex(string value) => (HtmlCanvasElement)WithAttribute(Attribute.TabIndex(value));
    }
}
