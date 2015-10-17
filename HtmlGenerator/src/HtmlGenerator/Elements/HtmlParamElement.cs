namespace HtmlGenerator
{
    public class HtmlParamElement : HtmlElement 
    {
        internal HtmlParamElement() : base("param", true) 
        {    
        }

		public HtmlParamElement WithNameAttribute(string value) => (HtmlParamElement)WithAttribute(Attribute.Name(value));

		public HtmlParamElement WithValueAttribute(string value) => (HtmlParamElement)WithAttribute(Attribute.Value(value));

		public HtmlParamElement WithAccessKey(string value) => (HtmlParamElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlParamElement WithClass(string value) => (HtmlParamElement)WithAttribute(Attribute.Class(value));

		public HtmlParamElement WithContentEditable(string value) => (HtmlParamElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlParamElement WithContextMenuAttribute(string value) => (HtmlParamElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlParamElement WithDir(string value) => (HtmlParamElement)WithAttribute(Attribute.Dir(value));

		public HtmlParamElement WithHidden(string value) => (HtmlParamElement)WithAttribute(Attribute.Hidden(value));

		public HtmlParamElement WithId(string value) => (HtmlParamElement)WithAttribute(Attribute.Id(value));

		public HtmlParamElement WithLang(string value) => (HtmlParamElement)WithAttribute(Attribute.Lang(value));

		public HtmlParamElement WithSpellCheck(string value) => (HtmlParamElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlParamElement WithStyleAttribute(string value) => (HtmlParamElement)WithAttribute(Attribute.Style(value));

		public HtmlParamElement WithTabIndex(string value) => (HtmlParamElement)WithAttribute(Attribute.TabIndex(value));
    }
}
