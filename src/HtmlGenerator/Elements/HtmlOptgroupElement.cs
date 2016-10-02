using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlOptgroupElement : HtmlElement
    {
        public HtmlOptgroupElement() : base("optgroup", false) 
        {    
        }

        public new HtmlOptgroupElement WithElement(HtmlElement element) => (HtmlOptgroupElement)base.WithElement(element);
        public new HtmlOptgroupElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlOptgroupElement)base.WithElements(elements);

        public new HtmlOptgroupElement WithInnerText(string innerText) => (HtmlOptgroupElement)base.WithInnerText(innerText);

        public new HtmlOptgroupElement WithAttribute(HtmlAttribute attribute) => (HtmlOptgroupElement)base.WithAttribute(attribute);
        public new HtmlOptgroupElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlOptgroupElement)base.WithAttributes(attributes);

		public HtmlOptgroupElement WithDisabled() => WithAttribute(Attribute.Disabled);

		public HtmlOptgroupElement WithLabel(string value) => WithAttribute(Attribute.Label(value));

		public HtmlOptgroupElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlOptgroupElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlOptgroupElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlOptgroupElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlOptgroupElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlOptgroupElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlOptgroupElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlOptgroupElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlOptgroupElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlOptgroupElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlOptgroupElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
