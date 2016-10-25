namespace HtmlGenerator.Elements
{
    public class HtmlMeterElement : HtmlElement
    {
        public HtmlMeterElement() : base("meter") { }

        public HtmlMeterElement WithForm(string value) => this.WithAttribute(Attribute.Form(value));

        public HtmlMeterElement WithLow(string value) => this.WithAttribute(Attribute.Low(value));

        public HtmlMeterElement WithHigh(string value) => this.WithAttribute(Attribute.High(value));

        public HtmlMeterElement WithMin(string value) => this.WithAttribute(Attribute.Min(value));

        public HtmlMeterElement WithMax(string value) => this.WithAttribute(Attribute.Max(value));

        public HtmlMeterElement WithOptimum(string value) => this.WithAttribute(Attribute.Optimum(value));

        public HtmlMeterElement WithValue(string value) => this.WithAttribute(Attribute.Value(value));
    }
}
