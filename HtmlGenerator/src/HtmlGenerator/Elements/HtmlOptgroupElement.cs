namespace HtmlGenerator
{
    public class HtmlOptgroupElement : HtmlElement 
    {
        internal HtmlOptgroupElement() : base("optgroup", false) 
        {    
        }

		public HtmlOptgroupElement WithDisabled() => (HtmlOptgroupElement)WithAttribute(Attribute.Disabled);

		public HtmlOptgroupElement WithLabel(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.Label(value));

		public HtmlOptgroupElement WithAccessKey(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlOptgroupElement WithClass(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.Class(value));

		public HtmlOptgroupElement WithContentEditable(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlOptgroupElement WithContextMenu(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlOptgroupElement WithDir(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.Dir(value));

		public HtmlOptgroupElement WithHidden(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.Hidden(value));

		public HtmlOptgroupElement WithId(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.Id(value));

		public HtmlOptgroupElement WithLang(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.Lang(value));

		public HtmlOptgroupElement WithSpellCheck(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlOptgroupElement WithStyle(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.Style(value));

		public HtmlOptgroupElement WithTabIndex(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.TabIndex(value));
    }
}
