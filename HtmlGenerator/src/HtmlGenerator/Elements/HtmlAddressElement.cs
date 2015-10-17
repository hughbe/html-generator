namespace HtmlGenerator
{
    public class HtmlAddressElement : HtmlElement 
    {
        internal HtmlAddressElement() : base("address", false) 
        {    
        }

		public HtmlAddressElement WithAccessKey(string value) => (HtmlAddressElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlAddressElement WithClass(string value) => (HtmlAddressElement)WithAttribute(Attribute.Class(value));

		public HtmlAddressElement WithContentEditable(string value) => (HtmlAddressElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlAddressElement WithContextMenuAttribute(string value) => (HtmlAddressElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlAddressElement WithDir(string value) => (HtmlAddressElement)WithAttribute(Attribute.Dir(value));

		public HtmlAddressElement WithHidden(string value) => (HtmlAddressElement)WithAttribute(Attribute.Hidden(value));

		public HtmlAddressElement WithId(string value) => (HtmlAddressElement)WithAttribute(Attribute.Id(value));

		public HtmlAddressElement WithLang(string value) => (HtmlAddressElement)WithAttribute(Attribute.Lang(value));

		public HtmlAddressElement WithSpellCheck(string value) => (HtmlAddressElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlAddressElement WithStyleAttribute(string value) => (HtmlAddressElement)WithAttribute(Attribute.Style(value));

		public HtmlAddressElement WithTabIndex(string value) => (HtmlAddressElement)WithAttribute(Attribute.TabIndex(value));
    }
}
