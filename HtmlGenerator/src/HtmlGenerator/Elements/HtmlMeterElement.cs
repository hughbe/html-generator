namespace HtmlGenerator
{
    public class HtmlMeterElement : HtmlElement 
    {
        internal HtmlMeterElement() : base("meter", false) 
        {    
        }

		public HtmlMeterElement WithForm(string value) => (HtmlMeterElement)WithAttribute(Attribute.Form(value));

		public HtmlMeterElement WithLow(string value) => (HtmlMeterElement)WithAttribute(Attribute.Low(value));

		public HtmlMeterElement WithHigh(string value) => (HtmlMeterElement)WithAttribute(Attribute.High(value));

		public HtmlMeterElement WithMin(string value) => (HtmlMeterElement)WithAttribute(Attribute.Min(value));

		public HtmlMeterElement WithMax(string value) => (HtmlMeterElement)WithAttribute(Attribute.Max(value));

		public HtmlMeterElement WithOptimum(string value) => (HtmlMeterElement)WithAttribute(Attribute.Optimum(value));

		public HtmlMeterElement WithValue(string value) => (HtmlMeterElement)WithAttribute(Attribute.Value(value));

		public HtmlMeterElement WithAccessKey(string value) => (HtmlMeterElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlMeterElement WithClass(string value) => (HtmlMeterElement)WithAttribute(Attribute.Class(value));

		public HtmlMeterElement WithContentEditable(string value) => (HtmlMeterElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlMeterElement WithContextMenu(string value) => (HtmlMeterElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlMeterElement WithDir(string value) => (HtmlMeterElement)WithAttribute(Attribute.Dir(value));

		public HtmlMeterElement WithHidden(string value) => (HtmlMeterElement)WithAttribute(Attribute.Hidden(value));

		public HtmlMeterElement WithId(string value) => (HtmlMeterElement)WithAttribute(Attribute.Id(value));

		public HtmlMeterElement WithLang(string value) => (HtmlMeterElement)WithAttribute(Attribute.Lang(value));

		public HtmlMeterElement WithSpellCheck(string value) => (HtmlMeterElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlMeterElement WithStyle(string value) => (HtmlMeterElement)WithAttribute(Attribute.Style(value));

		public HtmlMeterElement WithTabIndex(string value) => (HtmlMeterElement)WithAttribute(Attribute.TabIndex(value));
    }
}
