namespace HtmlGenerator
{
    public class HtmlLegendElement : HtmlElement 
    {
        internal HtmlLegendElement() : base("legend", false) 
        {    
        }

		public HtmlLegendElement WithAccessKey(string value) => (HtmlLegendElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlLegendElement WithClass(string value) => (HtmlLegendElement)WithAttribute(Attribute.Class(value));

		public HtmlLegendElement WithContentEditable(string value) => (HtmlLegendElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlLegendElement WithContextMenuAttribute(string value) => (HtmlLegendElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlLegendElement WithDir(string value) => (HtmlLegendElement)WithAttribute(Attribute.Dir(value));

		public HtmlLegendElement WithHidden(string value) => (HtmlLegendElement)WithAttribute(Attribute.Hidden(value));

		public HtmlLegendElement WithId(string value) => (HtmlLegendElement)WithAttribute(Attribute.Id(value));

		public HtmlLegendElement WithLang(string value) => (HtmlLegendElement)WithAttribute(Attribute.Lang(value));

		public HtmlLegendElement WithSpellCheck(string value) => (HtmlLegendElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlLegendElement WithStyleAttribute(string value) => (HtmlLegendElement)WithAttribute(Attribute.Style(value));

		public HtmlLegendElement WithTabIndex(string value) => (HtmlLegendElement)WithAttribute(Attribute.TabIndex(value));
    }
}
