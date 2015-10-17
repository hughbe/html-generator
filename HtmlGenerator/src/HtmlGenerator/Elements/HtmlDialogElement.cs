namespace HtmlGenerator
{
    public class HtmlDialogElement : HtmlElement 
    {
        internal HtmlDialogElement() : base("dialog", false) 
        {    
        }

		public HtmlDialogElement WithOpenAttribute(string value) => (HtmlDialogElement)WithAttribute(Attribute.Open(value));

		public HtmlDialogElement WithAccessKey(string value) => (HtmlDialogElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlDialogElement WithClass(string value) => (HtmlDialogElement)WithAttribute(Attribute.Class(value));

		public HtmlDialogElement WithContentEditable(string value) => (HtmlDialogElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlDialogElement WithContextMenuAttribute(string value) => (HtmlDialogElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlDialogElement WithDir(string value) => (HtmlDialogElement)WithAttribute(Attribute.Dir(value));

		public HtmlDialogElement WithHidden(string value) => (HtmlDialogElement)WithAttribute(Attribute.Hidden(value));

		public HtmlDialogElement WithId(string value) => (HtmlDialogElement)WithAttribute(Attribute.Id(value));

		public HtmlDialogElement WithLang(string value) => (HtmlDialogElement)WithAttribute(Attribute.Lang(value));

		public HtmlDialogElement WithSpellCheck(string value) => (HtmlDialogElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlDialogElement WithStyleAttribute(string value) => (HtmlDialogElement)WithAttribute(Attribute.Style(value));

		public HtmlDialogElement WithTabIndex(string value) => (HtmlDialogElement)WithAttribute(Attribute.TabIndex(value));
    }
}
