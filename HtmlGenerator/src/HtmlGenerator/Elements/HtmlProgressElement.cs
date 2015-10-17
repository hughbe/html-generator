namespace HtmlGenerator
{
    public class HtmlProgressElement : HtmlElement 
    {
        internal HtmlProgressElement() : base("progress", false) 
        {    
        }

		public HtmlProgressElement WithMaxAttribute(string value) => (HtmlProgressElement)WithAttribute(Attribute.Max(value));

		public HtmlProgressElement WithValueAttribute(string value) => (HtmlProgressElement)WithAttribute(Attribute.Value(value));

		public HtmlProgressElement WithAccessKey(string value) => (HtmlProgressElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlProgressElement WithClass(string value) => (HtmlProgressElement)WithAttribute(Attribute.Class(value));

		public HtmlProgressElement WithContentEditable(string value) => (HtmlProgressElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlProgressElement WithContextMenuAttribute(string value) => (HtmlProgressElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlProgressElement WithDir(string value) => (HtmlProgressElement)WithAttribute(Attribute.Dir(value));

		public HtmlProgressElement WithHidden(string value) => (HtmlProgressElement)WithAttribute(Attribute.Hidden(value));

		public HtmlProgressElement WithId(string value) => (HtmlProgressElement)WithAttribute(Attribute.Id(value));

		public HtmlProgressElement WithLang(string value) => (HtmlProgressElement)WithAttribute(Attribute.Lang(value));

		public HtmlProgressElement WithSpellCheck(string value) => (HtmlProgressElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlProgressElement WithStyleAttribute(string value) => (HtmlProgressElement)WithAttribute(Attribute.Style(value));

		public HtmlProgressElement WithTabIndex(string value) => (HtmlProgressElement)WithAttribute(Attribute.TabIndex(value));
    }
}
