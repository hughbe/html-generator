namespace HtmlGenerator
{
    public class HtmlOptgroupElement : HtmlElement
    {
        public HtmlOptgroupElement() : base("optgroup", false)
        {
        }

        public HtmlOptgroupElement WithDisabled() => this.WithAttribute(Attribute.Disabled);

        public HtmlOptgroupElement WithLabel(string value) => this.WithAttribute(Attribute.Label(value));
    }
}
