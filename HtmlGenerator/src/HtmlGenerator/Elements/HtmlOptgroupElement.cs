namespace HtmlGenerator
{
    public class HtmlOptgroupElement : HtmlElement 
    {
        internal HtmlOptgroupElement() : base("optgroup", false) 
        {    
        }

		public HtmlOptgroupElement WithDisabledAttribute() => (HtmlOptgroupElement)WithAttribute(Attribute.Disabled);

		public HtmlOptgroupElement WithLabelAttribute(string value) => (HtmlOptgroupElement)WithAttribute(Attribute.Label(value));
    }
}
