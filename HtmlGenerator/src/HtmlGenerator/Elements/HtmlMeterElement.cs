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
    }
}
