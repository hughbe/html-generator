namespace HtmlGenerator
{
    public class HtmlMeterElement : HtmlElement 
    {
        internal HtmlMeterElement() : base("meter", false) 
        {    
        }

		public HtmlMeterElement WithFormAttribute(string value) => (HtmlMeterElement)WithAttribute(Attribute.Form(value));

		public HtmlMeterElement WithLowAttribute(string value) => (HtmlMeterElement)WithAttribute(Attribute.Low(value));

		public HtmlMeterElement WithHighAttribute(string value) => (HtmlMeterElement)WithAttribute(Attribute.High(value));

		public HtmlMeterElement WithMinAttribute(string value) => (HtmlMeterElement)WithAttribute(Attribute.Min(value));

		public HtmlMeterElement WithMaxAttribute(string value) => (HtmlMeterElement)WithAttribute(Attribute.Max(value));

		public HtmlMeterElement WithOptimumAttribute(string value) => (HtmlMeterElement)WithAttribute(Attribute.Optimum(value));

		public HtmlMeterElement WithValueAttribute(string value) => (HtmlMeterElement)WithAttribute(Attribute.Value(value));

		public HtmlMeterElement WithAccessKey(string value) => (HtmlMeterElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMeterElement WithClass(string value) => (HtmlMeterElement)WithAttribute(Attribute.Class(value));

		public HtmlMeterElement WithContentEditable(string value) => (HtmlMeterElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMeterElement WithContextMenuAttribute(string value) => (HtmlMeterElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMeterElement WithDir(string value) => (HtmlMeterElement)WithAttribute(Attribute.Dir(value));

		public HtmlMeterElement WithHidden(string value) => (HtmlMeterElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMeterElement WithId(string value) => (HtmlMeterElement)WithAttribute(Attribute.Id(value));

		public HtmlMeterElement WithLang(string value) => (HtmlMeterElement)WithAttribute(Attribute.Lang(value));

		public HtmlMeterElement WithSpellCheck(string value) => (HtmlMeterElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMeterElement WithStyleAttribute(string value) => (HtmlMeterElement)WithAttribute(Attribute.Style(value));

		public HtmlMeterElement WithTabIndex(string value) => (HtmlMeterElement)WithAttribute(Attribute.TabIndex(value));
    }
}