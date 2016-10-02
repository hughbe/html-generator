using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlMeterElement : HtmlElement
    {
        public HtmlMeterElement() : base("meter", false) 
        {    
        }

        public new HtmlMeterElement WithElement(HtmlElement element) => (HtmlMeterElement)base.WithElement(element);
        public new HtmlMeterElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlMeterElement)base.WithElements(elements);

        public new HtmlMeterElement WithInnerText(string innerText) => (HtmlMeterElement)base.WithInnerText(innerText);

        public new HtmlMeterElement WithAttribute(HtmlAttribute attribute) => (HtmlMeterElement)base.WithAttribute(attribute);
        public new HtmlMeterElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlMeterElement)base.WithAttributes(attributes);

		public HtmlMeterElement WithForm(string value) => WithAttribute(Attribute.Form(value));

		public HtmlMeterElement WithLow(string value) => WithAttribute(Attribute.Low(value));

		public HtmlMeterElement WithHigh(string value) => WithAttribute(Attribute.High(value));

		public HtmlMeterElement WithMin(string value) => WithAttribute(Attribute.Min(value));

		public HtmlMeterElement WithMax(string value) => WithAttribute(Attribute.Max(value));

		public HtmlMeterElement WithOptimum(string value) => WithAttribute(Attribute.Optimum(value));

		public HtmlMeterElement WithValue(string value) => WithAttribute(Attribute.Value(value));

		public HtmlMeterElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlMeterElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlMeterElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlMeterElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlMeterElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlMeterElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlMeterElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlMeterElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlMeterElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlMeterElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlMeterElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
